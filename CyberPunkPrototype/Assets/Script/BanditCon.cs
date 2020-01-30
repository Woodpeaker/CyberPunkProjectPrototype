using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditCon : MonoBehaviour
{
    public float banditHP = 50;
    public float banditMaxHP = 50;
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
            GetComponent<Rigidbody>().velocity = new Vector2(-5, -0.3f);
            GetComponent<Animator>().SetTrigger("Bandit_Run");
            BattleFlow.currDamage = 30;
            StartCoroutine(IniPosition());
            BattleFlow.banditTurn = 2;
        }
    }

    IEnumerator IniPosition()
    {
        yield return new WaitForSeconds(1.5f);
        GetComponent<Animator>().SetTrigger("Bandit_Run_Melee");
        GetComponent<Rigidbody>().velocity = new Vector2(0, 0);
        yield return new WaitForSeconds(0.3f);
        Instantiate(damTextObj, new Vector2(-4.28f, -0.74f), damTextObj.rotation);
        yield return new WaitForSeconds(0.7f);
        GetComponent<Animator>().SetTrigger("Bandit_Melee_Idle");
        GetComponent<Transform>().position = new Vector2(4.4f, -0.97f);
    }
}
