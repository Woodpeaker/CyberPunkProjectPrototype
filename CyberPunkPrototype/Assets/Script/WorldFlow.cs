using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldFlow : MonoBehaviour
{

    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameFlow.inBattle)
        {
           player.gameObject.SetActive(false);
        }
        else
        {
            player.gameObject.SetActive(true);
        }
    }
}
