using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    public Dialogue dialogue;
    [SerializeField] private float delay = 0.01f;
    private DialogueManager dialogueManager;

    private void OnEnable()
    {
        dialogueManager = GetComponent<DialogueManager>();
    }
    private void Start()
    {
        if (dialogueManager == null)
        {
            Debug.LogError("DialogueManager ch?a ???c g�n!", this);
            return;
        }
        StartDialogue();
    }

    public void StartDialogue()
    {
        dialogueManager.BeginDialogue(dialogue, delay);
    }
}
