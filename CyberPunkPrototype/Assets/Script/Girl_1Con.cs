using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl_1Con : MonoBehaviour
{
    public Transform energyBallObj;
    public Transform damTextObj;
    public Transform hitEffectObj;
    public float girlHP = 50;
    public float girlMaxHP = 50;
    public float attackPower = 20;
    
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (BattleFlow.banditTurn == 3)
        {
            StartCoroutine(IniPosition());
            BattleFlow.banditTurn = 1;
        }
        if (BattleFlow.damageDisplay == "Y" && (BanditCon.target == 1))
        {
            girlHP -= BattleFlow.currDamage;
            Debug.Log("Girl HP: "+girlHP);
            BattleFlow.damageDisplay = "N";
        }
        if (girlHP <= 0)
        {
            BattleFlow.girlStatus = "DEAD";
            Destroy(gameObject);
        }
    }
    IEnumerator IniPosition()
    {
        Instantiate(energyBallObj, new Vector2(4.5f, -0.2f), energyBallObj.rotation);
        yield return new WaitForSeconds(0.9f);
        Instantiate(hitEffectObj, new Vector2(-3.46f, -0.2f),hitEffectObj.rotation);
        Instantiate(damTextObj, new Vector2(-3.46f, -1.03f), damTextObj.rotation);
        BanditCon.banditHP -= attackPower;
        Debug.Log("Bandit HP: " + BanditCon.banditHP);
        yield return new WaitForSeconds(1);
        GetComponent<Transform>().position = new Vector2(4.58f, -0.2f);
    }
}
