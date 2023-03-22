using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class normalScene : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player") && Random.Range(0, 9) != 0)
        {
            nextScene();
        }
        else
        {
            SceneManager.LoadScene(7);
        }
    }

    public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void setting()
    {
        SceneManager.LoadScene(8);
    }

}
