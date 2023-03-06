using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medicare : MonoBehaviour
{
    public static bool tree;
    // Start is called before the first frame update
    void Start()
    {
        tree = false;
    }
    void Update() {
        Debug.Log(tree);
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("tree")) {
            PlayerPrefs.SetInt("tree", 1);
        }
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "portal") {
            PlayerPrefs.SetInt("tree", 0);
        }
    }
    
}
