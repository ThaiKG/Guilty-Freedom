using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{

    public static GameObject[] tree;
    private static int rand;
    private static string treeidx;

    public static void randidx()
    {
        rand = Random.Range(0, 3);
        treeidx = tree[rand].name;
    }

    private void Update()
    {
        Debug.Log(rand);
    }

    private void OnCollisionEnter(Collision collision)
    {
        randidx();
        if (collision.gameObject.CompareTag(treeidx))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
