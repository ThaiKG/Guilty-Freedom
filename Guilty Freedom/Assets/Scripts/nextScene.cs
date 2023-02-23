using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{

    public GameObject[] tree;
    private int rand;
    private string treeidx;

    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(0, 3);
        treeidx = tree[rand].name;
        Debug.Log(rand);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(treeidx))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
