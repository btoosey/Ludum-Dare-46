using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{

    public int plantMaxHealth = 30;
    public int currentHealth;

    public HealthBar healthbar;

    void Start()
    {
        currentHealth = plantMaxHealth;
        healthbar.SetMaxHealth(plantMaxHealth);
        InvokeRepeating("TriggerDamage", 1f, 1f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }
    }

    void TriggerDamage()
    {
        TakeDamage(1);
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);
    }

    public void GainHealth(int health)
    {
        currentHealth += health;
        if (currentHealth > 30)
        {
            currentHealth = 30;
        }

        healthbar.SetHealth(currentHealth);
    }
}
