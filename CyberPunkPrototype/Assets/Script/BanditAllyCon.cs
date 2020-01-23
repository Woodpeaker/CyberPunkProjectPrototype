using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditAllyCon : MonoBehaviour
{
    public Transform energyBallObj;

    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("2"))
        {
            GetComponent<Transform>().position = new Vector2(2.13f, -1.24f);
            StartCoroutine(energyBallLaunch());
            GetComponent<Animator>().SetTrigger("BanditAllyRange");
            StartCoroutine(IniPosition());
        }
    }
    IEnumerator energyBallLaunch()
    {
        yield return new WaitForSeconds(1);
        Instantiate(energyBallObj, new Vector2(1.5f, -0.26f), energyBallObj.rotation);
    }
    IEnumerator IniPosition()
    {
        yield return new WaitForSeconds(2);
        GetComponent<Transform>().position = new Vector2(5.66f, -2.39f);
    }
}
