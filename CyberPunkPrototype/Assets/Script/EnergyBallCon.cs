﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBallCon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector2(-4, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
