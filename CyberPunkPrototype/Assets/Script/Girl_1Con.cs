using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl_1Con : MonoBehaviour
{
    public Transform energyBallObj;
    public Transform damTextObj;
    public static float girlHP = 100;
    public static float girlMaxHP = 100;
    
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (BattleFlow.banditTurn == 3)
        {
            BattleFlow.currDamage = 40;
            Instantiate(energyBallObj, new Vector2(-3.3f, -0.25f), energyBallObj.rotation);
            StartCoroutine(IniPosition());
            BattleFlow.banditTurn = 1;
        }
    }
    IEnumerator IniPosition()
    {
        yield return new WaitForSeconds(0.9f);
        Instantiate(damTextObj, new Vector2(4.4f, -0.25f), damTextObj.rotation);
        yield return new WaitForSeconds(1);
        GetComponent<Transform>().position = new Vector2(-4.28f, -0.74f);
    }
}
