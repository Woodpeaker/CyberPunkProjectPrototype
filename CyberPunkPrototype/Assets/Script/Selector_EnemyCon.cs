using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector_EnemyCon : MonoBehaviour
{
    public static float maxHeight;
    public static float minHeight;
    public static float xpos = 0;
    public float hoverSpeed = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().sortingOrder = 10;
        GetComponent<TextMesh>().text = "V";
        //this.transform.position = new Vector3(xpos, (maxHeight + minHeight) / 2.0f, 1);
    }

    // Update is called once per frame
    void Update()
    {
        float hoverHeight = (maxHeight + minHeight) / 2.0f;
        float hoverRange = maxHeight - minHeight;

        this.transform.position = new Vector3(xpos,hoverHeight * Mathf.Cos(Time.time * hoverSpeed) * hoverRange, 1); 
    }
}