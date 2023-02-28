using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{

    private void Update()
    {
        transform.LookAt(EnemyAI.player);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject, 3f);
    }
}
