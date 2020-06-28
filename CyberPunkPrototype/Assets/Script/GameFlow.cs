using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameFlow : MonoBehaviour
{

    public static bool inBattle = false;
    AsyncOperation Worldscene;
    AsyncOperation Battlescene;
    // Start is called before the first frame update
    void Start()
    {
        Worldscene = SceneManager.LoadSceneAsync("World Prototype", LoadSceneMode.Additive);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameFlow.inBattle && WorldFlow.Loaded)
        {
            WorldFlow.all_World_Objs = UnityEngine.Object.FindObjectsOfType<GameObject>();
            foreach (GameObject g in WorldFlow.all_World_Objs)
            {
                g.SetActive(false);
            }
            Battlescene =SceneManager.LoadSceneAsync("Battle Prototype", LoadSceneMode.Additive);
            WorldFlow.Loaded = false;
        }
    }
}
