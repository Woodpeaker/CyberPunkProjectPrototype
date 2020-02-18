using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditAllyCon : MonoBehaviour
{
    public float banditAllyHP = 50;
    public float banditAllyMaxHP = 50;
    public float attackPower = 10;
    public int EXP = 100;
    public Transform damTextObj;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if ((BattleFlow.banditTurn == 2)&&(gameObject.name=="Bandit Ally"))
        {
            StartCoroutine(IniPosition());
            BattleFlow.banditTurn = 3;
        }
        if ((BattleFlow.banditTurn == 3) && (gameObject.name == "Bandit Ally 2"))
        {
            StartCoroutine(IniPosition());
            BattleFlow.banditTurn = 4;
        }
        if (BattleFlow.damageDisplay == "Y" && (BattleFlow.selectedEnemy == gameObject.name))
        {
            banditAllyHP -= BattleFlow.currDamage;
            Debug.Log("Bandit Ally HP: "+banditAllyHP);
            BattleFlow.damageDisplay = "N";
        }
        if ((banditAllyHP <= 0)&& (gameObject.name == "Bandit Ally"))
        {
            BattleFlow.banditAllyStatus="DEAD";
            BattleFlow.banditTotalEXP += EXP;
            Debug.Log("Bandit gain +" +EXP+" EXP");
            Destroy(gameObject);
        }
        if ((banditAllyHP <= 0) && (gameObject.name == "Bandit Ally 2"))
        {
            BattleFlow.banditAlly2Status = "DEAD";
            BattleFlow.banditTotalEXP += EXP;
            Debug.Log("Bandit gain +" + EXP + " EXP");
            Destroy(gameObject);
        }
    }
    IEnumerator IniPosition()
    {
        if (gameObject.name == "Bandit Ally")
            yield return new WaitForSeconds(1);
        else if (gameObject.name == "Bandit Ally 2")
        {
            if (BattleFlow.banditAllyStatus == "DEAD")
                yield return new WaitForSeconds(1);
            else
                yield return new WaitForSeconds(3);
        }
        GetComponent<Transform>().position = new Vector2(-3.10f, -1.03f);
        GetComponent<Animator>().SetTrigger("BanditAllyRange");
        yield return new WaitForSeconds(1);
        Instantiate(damTextObj, new Vector2(-3.56f, -1.03f), damTextObj.rotation);
        BanditCon.banditHP -= attackPower;
        Debug.Log("Bandit HP: " + BanditCon.banditHP);
        if (gameObject.name=="Bandit Ally")
            GetComponent<Transform>().position = new Vector2(5.66f, -2.39f);
        else if(gameObject.name=="Bandit Ally 2")
            GetComponent<Transform>().position = new Vector2(5.48f, 1f);
    }
    void OnMouseDown()
    {
        BattleFlow.selectedEnemy = gameObject.name;
    }
}
