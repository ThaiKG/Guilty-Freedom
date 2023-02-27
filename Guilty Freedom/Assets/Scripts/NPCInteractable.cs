using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractable : MonoBehaviour
{
    public GameObject dialogue;
    private Dialogue thing;

    void start(){
        thing = dialogue.GetComponent<Dialogue>();
    }
    public void Interact(){
        Debug.Log("Interact!");
    }
}
