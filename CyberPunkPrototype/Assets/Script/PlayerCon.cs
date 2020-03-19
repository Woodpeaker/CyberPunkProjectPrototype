﻿using System.Collections;
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

        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(hAxis,vAxis, 0) * speed * Time.deltaTime;
        rig.MovePosition(transform.position + movement);
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