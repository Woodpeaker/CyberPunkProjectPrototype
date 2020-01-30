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
            GetComponent<Transform>().position = new Vector2(-3.33f, -1.6f);
            GetComponent<Animator>().SetTrigger("BanditAllyRange");
            Instantiate(damTextObj, new Vector2(-4.28f, -0.74f), damTextObj.rotation);
            BattleFlow.currDamage = 30;
        }
    }
    void IniPositionAlly()
    {
        GetComponent<Transform>().position = new Vector2(5.66f, -2.39f);
        BattleFlow.banditTurn = 3;
    }
}
