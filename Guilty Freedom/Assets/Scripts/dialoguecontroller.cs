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
            dialogue.SetActive(true);
            string[] temp = {"teddy gay", "ur mom gae", "hello"};
            thing.lines = temp;
            thing.textSpeed = 0.1f;
            d1 = false;
        }
    }
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("npc1")) {
            d1 = true;
        }
    }
}
