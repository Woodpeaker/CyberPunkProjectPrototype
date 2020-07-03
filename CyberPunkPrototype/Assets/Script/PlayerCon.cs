using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{

    public float speed = 10f;
    private Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameFlow.IsInputEnabled)
        {
            float hAxis = Input.GetAxis("Horizontal");
            float vAxis = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(hAxis,vAxis, 0) * speed * Time.deltaTime;
            rig.MovePosition(transform.position + movement);
            if (GameFlow.inBattle)
            {
                //gameObject.SetActive(false);
            }
            else {
                gameObject.SetActive(true);
            }
            if (hAxis > 0)
            {
                GetComponent<Transform>().localScale = new Vector3(-4.581f,4.812f,1);
            }
            else if (hAxis < 0)
            {
                GetComponent<Transform>().localScale = new Vector3(4.581f, 4.812f, 1);
            }
            if (Mathf.Abs(hAxis) > 0.1 || Mathf.Abs(vAxis) > 0.1 )
            {
                GetComponent<Animator>().SetBool("isPlayerRunning",true);
            }
            else
            {
                GetComponent<Animator>().SetBool("isPlayerRunning", false);
            }
        }


    }
}
