using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class falltobottom : MonoBehaviour
{
    void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("player")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player") && SceneManager.GetActiveScene().buildIndex != 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            waiter();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(0.3f);
    }

}
