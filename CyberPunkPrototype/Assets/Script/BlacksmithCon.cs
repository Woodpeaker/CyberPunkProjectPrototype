using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlacksmithCon : MonoBehaviour
{
    public Dialogue dialogue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
    private void OnCollisionEnter(Collision other)
    { 
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject.Find("Player").GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F) && !DialogueManager.isTalking){
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        else if (Input.anyKeyDown && DialogueManager.isTalking)
        {
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
        }
    }
}
