using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollectableCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public int count;
    public TextMeshProUGUI collect;
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        collect.text = "Treasures needed: " + score + "/6";
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "treasure") {
            count++;
        }
    }
}
