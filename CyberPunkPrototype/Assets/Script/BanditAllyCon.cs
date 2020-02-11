using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditAllyCon : MonoBehaviour
{
    public float banditAllyHP = 50;
    public float banditAllyMaxHP = 50;
    public float attackPower = 10;
    public Transform damTextObj;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("1") && (BattleFlow.banditTurn == 2))
        {
            GetComponent<Transform>().position = new Vector2(-3.10f, -1.03f);
            GetComponent<Animator>().SetTrigger("BanditAllyRange");
            Instantiate(damTextObj, new Vector2(-3.56f, -1.03f), damTextObj.rotation);
            BanditCon.banditHP -= attackPower;
            Debug.Log("Bandit HP: "+BanditCon.banditHP);
        }
        if (BattleFlow.damageDisplay == "Y" && (BanditCon.target == 2))
        {
            banditAllyHP -= BattleFlow.currDamage;
            Debug.Log("Bandit Ally HP: "+banditAllyHP);
            BattleFlow.damageDisplay = "N";
        }
        if (banditAllyHP <= 0)
        {
            BattleFlow.banditAllyStatus="DEAD";
            Destroy(gameObject);
        }
    }
    void IniPositionAlly()
    {
        GetComponent<Transform>().position = new Vector2(5.66f, -2.39f);
        BattleFlow.banditTurn = 3;
    }
}
