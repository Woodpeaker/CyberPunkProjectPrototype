using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl_1Con : MonoBehaviour
{
    public Transform energyBallObj;

    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("3"))
        {
            Instantiate(energyBallObj, new Vector2(-3.3f, -0.25f), energyBallObj.rotation);
            StartCoroutine(IniPosition());
        }
    }
    IEnumerator IniPosition()
    {
        yield return new WaitForSeconds(2);
        GetComponent<Transform>().position = new Vector2(-4.28f, -0.74f);
    }
}
