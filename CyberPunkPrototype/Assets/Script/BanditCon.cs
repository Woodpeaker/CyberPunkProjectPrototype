using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditCon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            GetComponent<Rigidbody>().velocity = new Vector2(-5, 0);
            GetComponent<Animator>().SetTrigger("Bandit_Run");
            //GetComponent<Transform>().position = new Vector2(-3.33f,-1.6f);
            StartCoroutine(IniPosition());
            
        }
    }

    IEnumerator IniPosition()
    {
        //yield return new WaitForSeconds(1.5f);
        GetComponent<Animator>().SetTrigger("Bandit_Melee");
        GetComponent<Rigidbody>().velocity = new Vector2(0, 0);
        yield return new WaitForSeconds(1);
        GetComponent<Transform>().position = new Vector2(4.4f, -0.97f);
    }
}
