using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl_1Con : MonoBehaviour
{
    public Transform energyBallObj;
    public Transform damTextObj;
    public float girlHP = 20;
    public float girlMaxHP = 20;
    
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (BattleFlow.banditTurn == 3)
        {
            BattleFlow.target = 1;
            BattleFlow.currDamage = 20;
            Instantiate(energyBallObj, new Vector2(4.5f, -0.2f), energyBallObj.rotation);
            StartCoroutine(IniPosition());
            BattleFlow.banditTurn = 1;
        }
        if (BattleFlow.damageDisplay == "Y" && (BattleFlow.target == 3))
        {
            girlHP -= BattleFlow.currDamage;
            Debug.Log(girlHP);
            BattleFlow.damageDisplay = "N";
        }
        if (girlHP <= 0)
            Destroy(gameObject);
    }
    IEnumerator IniPosition()
    {
        yield return new WaitForSeconds(0.9f);
        Instantiate(damTextObj, new Vector2(-3.46f, -1.03f), damTextObj.rotation);
        BattleFlow.damageDisplay = "Y";
        yield return new WaitForSeconds(1);
        GetComponent<Transform>().position = new Vector2(4.58f, -0.2f);
    }
}
