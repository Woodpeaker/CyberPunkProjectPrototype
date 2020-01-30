using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damTextCon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().sortingOrder = 10;
        GetComponent<TextMesh>().text = BattleFlow.currDamage.ToString();
        GetComponent<Rigidbody>().velocity = new Vector2(0, 1);
        Destroy(gameObject, 0.9f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
