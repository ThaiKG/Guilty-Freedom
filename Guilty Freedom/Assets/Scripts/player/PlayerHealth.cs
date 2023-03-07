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
        healthBar = GetComponent<HealthBar>();
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int damage){
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            TakeDamage(5);
        }
    }

}
