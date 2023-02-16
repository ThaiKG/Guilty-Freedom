using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class dialoguecontroller : MonoBehaviour
{
    public GameObject dialogue;
    private Dialogue thing;
    private bool d1, d2;
    private MeshRenderer r;
    // Start is called before the first frame update
    void Start()
    {
        dialogue.SetActive(false);
        thing = dialogue.GetComponent<Dialogue>();
    }

    // Update is called once per frame
    void Update()
    {

        if (d1) {
            thing.idx = 0;
            thing.textSpeed = 0.1f;
            string[] temp = {"You can use WASD to move", "Use the mouse to look around", "And you will not escape the plantation my slave"};
            thing.lines = temp;
            // thing.StartDialogue();
            dialogue.SetActive(true);
            d1 = false;
            if (thing.done) {
                thing.done = false;
            }
            
        } else if (d2) {
            thing.idx = 0;
            thing.textSpeed = 0.1f;
            string[] temp = {"Psssssst...", "We can help you escape the plantation and gain your freedom", "First complete the platform level and get all of the coin bags in the neighboring village", "Go into the Magic Tree or the portal to start your journey", "The magic tree is hidden, but it will grant your a reward", "Good luck!"};
            thing.lines = temp;
            // thing.StartDialogue();
            dialogue.SetActive(true);
            d2 = false;
            
            if (thing.done) {
                // SceneManager.LoadScene(1);
                thing.done = false;
            }
        }
    }
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("npc1")) {
            d1 = true;
        } else if (other.CompareTag("npc2")) {
            d2 = true;
        }
    }
}
