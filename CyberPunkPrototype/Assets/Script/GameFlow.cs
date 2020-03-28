using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFlow : MonoBehaviour
{

    public static bool inBattle = false;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(sceneName: "World Prototype", LoadSceneMode.Additive);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
