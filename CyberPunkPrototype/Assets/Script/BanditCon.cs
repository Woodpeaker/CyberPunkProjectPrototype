using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditCon : MonoBehaviour
{
    public float banditHP = 100;
    public float banditMaxHP = 100;
    public Transform damTextObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1")&&(BattleFlow.banditTurn==1))
        {
            BattleFlow.target = 3;
            GetComponent<Rigidbody>().velocity = new Vector2(5, 0);
            GetComponent<Animator>().SetTrigger("Bandit_Run");
            BattleFlow.currDamage = 10;
            StartCoroutine(IniPosition());
            BattleFlow.banditTurn = 2;
        }
        if (BattleFlow.damageDisplay == "Y" && (BattleFlow.target == 1))
        {
            banditHP -= BattleFlow.currDamage;
            Debug.Log(banditHP);
            BattleFlow.damageDisplay = "N";
        }
        if (banditHP <= 0)
            Destroy(gameObject);
    }

    IEnumerator IniPosition()
    {
        yield return new WaitForSeconds(1.5f);
        GetComponent<Animator>().SetTrigger("Bandit_Run_Melee");
        GetComponent<Rigidbody>().velocity = new Vector2(0, 0);
        yield return new WaitForSeconds(0.3f);
        Instantiate(damTextObj, new Vector2(4.58f, -0.2f), damTextObj.rotation);
        BattleFlow.damageDisplay = "Y";
        yield return new WaitForSeconds(0.7f);
        GetComponent<Animator>().SetTrigger("Bandit_Melee_Idle");
        GetComponent<Transform>().position = new Vector2(-3.56f, -1.03f);
    }
}
