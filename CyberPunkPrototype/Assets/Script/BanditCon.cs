using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditCon : MonoBehaviour
{
    public static float banditHP = 100;
    public static float banditMaxHP = 100;
    public Transform damTextObj;
    public static int target = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1")&&(BattleFlow.banditTurn==1))
        {
            target = Random.Range(1,3);
            if (BattleFlow.girlStatus == "DEAD")
                target = 2;
            if (BattleFlow.banditAllyStatus == "DEAD")
                target = 1;
            if (target==1)
                GetComponent<Rigidbody>().velocity = new Vector2(5, 0);
            else
                GetComponent<Rigidbody>().velocity = new Vector2(5.5f, -1.2f);
            GetComponent<Animator>().SetTrigger("Bandit_Run");
            BattleFlow.currDamage = 30;
            StartCoroutine(IniPosition());
            BattleFlow.banditTurn = 2;
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
        if (target == 1)
        {
            Instantiate(damTextObj, new Vector2(4.58f, -0.2f), damTextObj.rotation);
        }
        else
        {
            Instantiate(damTextObj, new Vector2(5.66f, -2.39f), damTextObj.rotation);
        }
        yield return new WaitForSeconds(0.7f);
        GetComponent<Animator>().SetTrigger("Bandit_Melee_Idle");
        GetComponent<Transform>().position = new Vector2(-3.56f, -1.03f);
        BattleFlow.damageDisplay = "Y";
    }
}
