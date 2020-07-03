﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BanditExploreCon : MonoBehaviour
{
    public Transform Player;
    public float speed = 10f;
    private float distance;
    public float sight=10;
    public bool isFollowing = false;
    public Vector3 startingPos;
    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(Player.position,transform.position);

        //transform.LookAt(Player);
        if (distance <= sight)
        {
            isFollowing = true;
        }
        if (isFollowing)
        {
            if (distance <= 10)
            {
                Vector3 displacement = Player.position - transform.position;
                displacement = displacement.normalized;
                if (Vector2.Distance(Player.position, transform.position) > 1.0f)
                {
                    transform.position += (displacement * speed * Time.deltaTime);
                }
                if (displacement.magnitude > 0)
                {
                    GetComponent<Animator>().SetBool("isBanditRunning", true);
                }
                else
                {
                    GetComponent<Animator>().SetBool("isBanditRunning", false);
                }
            }
            else
            {
                isFollowing = false;
            }
        }
        else {

            Vector3 displacement = startingPos - transform.position;
            displacement = displacement.normalized;
            if (Vector2.Distance(startingPos, transform.position) > 1.0f)
            {
                transform.position += (displacement * speed * Time.deltaTime);
            }
            if (displacement.magnitude > 0)
            {
                GetComponent<Animator>().SetBool("isBanditRunning", true);
            }
            else
            {
                GetComponent<Animator>().SetBool("isBanditRunning", false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        GameFlow.inBattle = true;
        Destroy(gameObject);
    }
}
