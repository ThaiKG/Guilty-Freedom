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
        
        
    }
    void OnTriggerEnter(Collider other) {
        
    }
}
