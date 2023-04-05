using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class falltobottom : MonoBehaviour
{
    public AudioSource OOF;
    void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("player")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            OOF.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player") && SceneManager.GetActiveScene().buildIndex != 4)
        
        {
            OOF.Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            waiter();
            OOF.Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(0.3f);
    }

}
