using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollectableCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public int count;
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "treasure") {
            count++;
        }
    }
}
