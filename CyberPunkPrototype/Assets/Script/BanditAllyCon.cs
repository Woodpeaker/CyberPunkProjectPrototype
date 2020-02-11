using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditAllyCon : MonoBehaviour
{
    public float banditAllyHP = 50;
    public float banditAllyMaxHP = 50;
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
            BattleFlow.target = 1;
            GetComponent<Transform>().position = new Vector2(-3.10f, -1.03f);
            GetComponent<Animator>().SetTrigger("BanditAllyRange");
            Instantiate(damTextObj, new Vector2(-3.56f, -1.03f), damTextObj.rotation);
            BattleFlow.damageDisplay = "Y";
            BattleFlow.currDamage = 10;
        }
    }
    void IniPositionAlly()
    {
        GetComponent<Transform>().position = new Vector2(5.66f, -2.39f);
        BattleFlow.banditTurn = 3;
    }
}
