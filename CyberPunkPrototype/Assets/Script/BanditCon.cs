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

            GetComponent<Transform>().position = new Vector2(-3.33f,-1.6f);
            GetComponent<Animator>().SetTrigger("Bandit_Melee");
        }
        

    }

    void IniPosition()
    {
        GetComponent<Transform>().position = new Vector2(4.4f, -0.97f);
    }
}
