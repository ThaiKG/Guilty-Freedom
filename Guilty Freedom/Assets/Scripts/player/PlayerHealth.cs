using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    private int cnt;

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
        if (currentHealth <= 0 && cnt == 2)
        {
            SceneManager.LoadScene(6);
        }
        else if (currentHealth <= 0)
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

        if (other.gameObject.CompareTag("obstacles"))
        {
            cnt++;
            TakeDamage(50);
        }

    }

}
