using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleFlow : MonoBehaviour
{

    public static int banditTurn = 1;
    public static float currDamage = 0;
    public static string damageDisplay = "N";
    public static string girlStatus = "OK";
    public static string banditAllyStatus = "OK";
    public static string banditAlly2Status = "OK";
    public static string selectedEnemy = "";
    public static int banditTotalEXP = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((girlStatus == "DEAD")&&(banditTurn==4))
        {
            banditTurn = 1;
        }
        if ((banditAllyStatus == "DEAD") && (banditTurn == 2))
        {
            banditTurn = 3;
        }
        if ((banditAlly2Status == "DEAD") && (banditTurn == 3))
        {
            banditTurn = 4;
        }
    }
}
