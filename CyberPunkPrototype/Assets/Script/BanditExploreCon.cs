using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BanditExploreCon : MonoBehaviour
{
    public Transform Player;
    public float speed = 10f;
    private float distance;
    public float sight=10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(Player.position,transform.position);

        //transform.LookAt(Player);
        if (distance <= sight)
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
    }

    private void OnTriggerEnter(Collider other)
    {
        GameFlow.inBattle = true;
        SceneManager.LoadScene(sceneName: "Battle Prototype", LoadSceneMode.Additive);
        Destroy(gameObject);
    }
}
