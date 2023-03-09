using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInteractUI : MonoBehaviour
{   
    
    [SerializeField] private PlayerInteract playerInteract;

    [SerializeField] private GameObject containerGameObject;
    [SerializeField] private TextMeshProUGUI interactableText;

    private void Update(){
        if(playerInteract.GetInteractableObject() != null){
            Show(playerInteract.GetInteractableObject());
        } else{
            Hide();
        }
    }
    private void Show(IInteractable interactable){
        containerGameObject.SetActive(true);
        interactableText.text = interactable.getInteractText();
    }

    private void Hide(){
        containerGameObject.SetActive(false);
    }
}
