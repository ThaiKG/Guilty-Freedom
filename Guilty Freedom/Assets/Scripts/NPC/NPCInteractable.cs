using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractable : MonoBehaviour
{
    [SerializeField] private string InteractText;
    [SerializeField] private string[] dialogues;
    public GameObject dialogue;
    private Dialogue dialogueComponent;

    public bool isInteracting = false;

    void start(){
        dialogueComponent = dialogue.GetComponent<Dialogue>();

    }

    void Update(){
        try{
            if(dialogueComponent.done){
            isInteracting = false;
            }
        }catch{

        }
        
    }
    public void Interact(){
        
        if(isInteracting == false){
            isInteracting = true;
            Debug.Log("Interact!");
            dialogue.SetActive(true);
            dialogueComponent = dialogue.GetComponent<Dialogue>();
            dialogueComponent.lines = dialogues;
            dialogueComponent.StartDialogue();
            if (dialogueComponent.done) {
                dialogueComponent.done = false;
            }
        } else{
            Debug.Log("Cannot Interact");
        }
            
    }

    public string getInteractText(){
        return InteractText;
    }
}
