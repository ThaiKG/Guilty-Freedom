using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class dialoguecontroller : MonoBehaviour
{
    public GameObject dialogue;
    private Dialogue thing;
    private bool d1, d2, d1done = false;
    private MeshRenderer r;
    // Start is called before the first frame update
    void Start()
    {
        dialogue.SetActive(true);
        thing = dialogue.GetComponent<Dialogue>();
    }

    // Update is called once per frame
    void Update()
    {

        if (dialogue.activeSelf == false && d1 && d1done == false) {
            string[] temp = {"You are awake? GET TO WORK YOU WORTHLESS PIG!!!", "Oh, and don't even think about escaping, my land is full of guards HAHAHA"};
            thing.lines = temp;
            dialogue.SetActive(true);
            thing.StartDialogue();
            d1 = false;
            if (thing.done) {
                thing.done = false;
            }
            d1done = true;
            
        }else if(dialogue.activeSelf == false && d1done == true){
            string[] temp = {"GET TO WORK!!!"};
            thing.lines = temp;
            dialogue.SetActive(true);
            thing.StartDialogue();
            if (thing.done) {
                thing.done = false;
            }
        }
         else if (dialogue.activeSelf == false && d2) {
            string[] temp = {"Psssssst...", "We can help you escape the plantation and gain your freedom", "First complete the platform level and get all of the coin bags in the neighboring village", "Go into the Magic Tree or the portal to start your journey", "The magic tree is hidden, but it will grant your a reward", "Good luck!"};
            thing.lines = temp;
            dialogue.SetActive(true);
            thing.StartDialogue();
            d2 = false;
            if (thing.done) {
                // SceneManager.LoadScene(1);
                thing.done = false;
            }
        }
    }
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("npc1") && d1done == false) {
            d1 = true;
        } else if (other.CompareTag("npc2")) {
            d2 = true;
        }
    }
}
