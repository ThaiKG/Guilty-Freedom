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

    private void Update()
    {
        if (currentHealth >= 0)
        {
            PlayerMovement.Reset();
        }
    }

    public void TakeDamage(int damage){
        currentHealth -= damage;
        Debug.Log(healthBar);
        healthBar.SetHealth(currentHealth);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("axe"))
        {
            TakeDamage(5);
        }

    }

}
