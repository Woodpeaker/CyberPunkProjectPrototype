using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditCon : MonoBehaviour
{
    public static float banditHP = 200;
    public static float banditMaxHP = 200;
    public Transform damTextObj;
    public static int target = 0;
    public bool targetFound = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((BattleFlow.attackStatus=="Player Attack")&&(BattleFlow.banditTurn==1))
        {
            BattleFlow.attackStatus = "none";
            BattleFlow.selectedEnemy = "Girl 1";
            if (BattleFlow.girlStatus == "DEAD")
            {
                BattleFlow.selectedEnemy = "Bandit Ally";
                if (BattleFlow.banditAllyStatus == "DEAD")
                    BattleFlow.selectedEnemy = "Bandit Ally 2";
            }
            
            if ((BattleFlow.selectedEnemy == "Girl 1"))
                GetComponent<Rigidbody>().velocity = new Vector2(5, 0);
            else if ((BattleFlow.selectedEnemy == "Bandit Ally"))
                GetComponent<Rigidbody>().velocity = new Vector2(5.5f, -1.2f);
            else if((BattleFlow.selectedEnemy == "Bandit Ally 2"))
                GetComponent<Rigidbody>().velocity = new Vector2(5.5f, 1.2f);
            GetComponent<Animator>().SetTrigger("Bandit_Run");
            BattleFlow.currDamage = 30;
            StartCoroutine(IniPosition());
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
        if ((BattleFlow.selectedEnemy == "Girl 1"))
        {
            Instantiate(damTextObj, new Vector2(4.58f, -0.2f), damTextObj.rotation);
        }
        else if ((BattleFlow.selectedEnemy == "Bandit Ally"))
        {
            Instantiate(damTextObj, new Vector2(5.66f, -2.39f), damTextObj.rotation);
        }
        else if((BattleFlow.selectedEnemy == "Bandit Ally 2"))
        {
            Instantiate(damTextObj, new Vector2(5.48f, 1), damTextObj.rotation);
        }
        yield return new WaitForSeconds(0.7f);
        GetComponent<Animator>().SetTrigger("Bandit_Melee_Idle");
        GetComponent<Transform>().position = new Vector2(-3.56f, -1.03f);
        BattleFlow.damageDisplay = "Y";
        BattleFlow.banditTurn = 2;
    }
}
