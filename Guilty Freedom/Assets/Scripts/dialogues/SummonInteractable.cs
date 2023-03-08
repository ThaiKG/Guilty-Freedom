using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonInteractable : MonoBehaviour, IInteractable
{
    public string getInteractText()
    {
        return "Summon";
    }

    public void Interact(Transform interactorTransform)
    {
        //start cutscene
    }

    public Transform GetTransform(){
        return transform;
    }
}
