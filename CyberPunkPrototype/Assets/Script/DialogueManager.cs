using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public Animator animator;
    private GameObject player;
    public static bool isTalking;
    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        isTalking = false;
        sentences = new Queue<string>();
        player = GameObject.Find("Player");
    }
    public void StartDialogue(Dialogue dialogue)
    {
        GameFlow.IsInputEnabled = false;
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.GetComponent<PlayerCon>().speed = 0;
        animator.SetBool("IsOpen", true);
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        isTalking = true;
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence=sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
    void EndDialogue()
    {
        GameFlow.IsInputEnabled = true;
        isTalking = false;
        animator.SetBool("IsOpen", false);
        player.GetComponent<Rigidbody>().isKinematic = true;
        player.GetComponent<PlayerCon>().speed = 18;
        Debug.Log("End of conversation");
    }
}
