using System;
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
        //PlayerPrefs.DeleteAll();

        cnt = PlayerPrefs.GetInt("cnt");

        if (cnt == 2)
        {
            PlayerPrefs.DeleteAll();
            SceneManager.LoadScene(7);
        }
        else if (PlayerPrefs.GetInt("health", currentHealth) >= 0)
        {
            currentHealth = PlayerPrefs.GetInt("health");
        }
        else
        {
            currentHealth = maxHealth;
            PlayerPrefs.SetInt("health", maxHealth);
        }

        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(currentHealth);

        Debug.Log(currentHealth);
        Debug.Log(cnt);
    }

    private void Update()
    {
        if (currentHealth <= 0 && SceneManager.GetActiveScene().buildIndex != 4)
        {
            PlayerMovement.Reset();
        }
        else if (currentHealth <= 0 && SceneManager.GetActiveScene().buildIndex == 4)
        {
            PlayerPrefs.DeleteAll();
            SceneManager.LoadScene(7);
        }
    }

    public void TakeDamage(int damage){
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("axe"))
        {
            TakeDamage(5);
        }

        if (other.gameObject.CompareTag("floor"))
        {
            TakeDamage(20);
            PlayerPrefs.SetInt("health", currentHealth);
        }

        if (other.gameObject.CompareTag("obstacles"))
        {
            cnt += 1;
            TakeDamage(50);
            PlayerPrefs.SetInt("health", currentHealth);
            PlayerPrefs.SetInt("cnt", cnt);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

}
