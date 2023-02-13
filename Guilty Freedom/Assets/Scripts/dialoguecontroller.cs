using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialoguecontroller : MonoBehaviour
{
    public GameObject dialogue;
    private Dialogue thing;
    private bool d1;
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
            
        }
    }
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("npc1")) {
            d1 = true;
        }
    }
}
