using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asProjectile : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 3f);
        Vector3 temp = new Vector3(0, 180, 0);
        transform.LookAt(EnemyAI.player, temp);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            PlayerHealth.TakeDamage(10);
        }

        if (!other.gameObject.CompareTag("enemy"))
        {
            Destroy(gameObject);
        }
    }

}
