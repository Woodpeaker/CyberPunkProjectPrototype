using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditAllyCon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("2"))
        {

            GetComponent<Transform>().position = new Vector2(-3.33f, -1.6f);
            GetComponent<Animator>().SetTrigger("BanditAllyRange");
        }
    }
    void IniPosition()
    {
        GetComponent<Transform>().position = new Vector2(5.66f, -2.39f);
    }
}
