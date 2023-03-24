using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class falltobottom : MonoBehaviour
{
    public AudioSource OOF;
    void Start() {
        OOF = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("player")) {
            OOF.Play();
            Debug.Log(OOF);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
            Debug.Log(1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player") && SceneManager.GetActiveScene().buildIndex != 4)
        {
            OOF.Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log(2);
            
            
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            OOF.Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log(3);
            
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(0.3f);
    }

}
