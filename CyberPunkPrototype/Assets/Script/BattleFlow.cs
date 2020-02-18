using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public static string attackStatus = "none";

    public Transform healthBar;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.GetComponent<Image>().color = new Color(0,1,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (BanditCon.banditHP< BanditCon.banditMaxHP)
        {
            healthBar.GetComponent<Image>().color = new Color(1, 1, 0);
        }
        if (BanditCon.banditHP < (BanditCon.banditMaxHP/2))
        {
            healthBar.GetComponent<Image>().color = new Color(1,0, 0);
        }
        healthBar.GetComponent<RectTransform>().localScale = new Vector2(BanditCon.banditHP/ BanditCon.banditMaxHP,1);

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
    public void attackEnabled()
    {
        attackStatus = "Player Attack";
    }
}
