using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldFlow : MonoBehaviour
{

    public Transform player;
    public static bool Loaded;
    // Start is called before the first frame update
    public static GameObject[] all_World_Objs;
    void Start()
    {
        Loaded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameFlow.inBattle && Loaded)
        {

        }
    }
}
