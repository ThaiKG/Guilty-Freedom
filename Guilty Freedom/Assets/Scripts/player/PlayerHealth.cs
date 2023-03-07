using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        // healthBar = GetComponent<HealthBar>();
        healthBar.SetMaxHealth(maxHealth);
        Debug.Log(healthBar);
    }

    public void TakeDamage(int damage){
        currentHealth -= damage;
        Debug.Log(healthBar);
        healthBar.SetHealth(currentHealth);
    }

    private void Update()
    {
        // if (Input.GetKey(KeyCode.Space))
        // {
        //     TakeDamage(5);
        // }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("axe"))
        {
            currentHealth = 0;
        }

    }

}
