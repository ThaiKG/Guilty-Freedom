using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tree : MonoBehaviour
{
    public GameObject[] setTrees;
    public static GameObject[] trees;
    private static int rand;
    private static string treeidx;
    public static GameObject player;

    private void Start()
    {
        trees = setTrees;
        randidx();
    }

    public static void randidx()
    {
        rand = Random.Range(0, 3);
        treeidx = trees[rand].name;
        Debug.Log(rand);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(treeidx))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } else if (PlayerPrefs.GetInt("tree") == 1 && (collision.gameObject.CompareTag("tree1") || collision.gameObject.CompareTag("tree2") || collision.gameObject.CompareTag("tree3"))) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
