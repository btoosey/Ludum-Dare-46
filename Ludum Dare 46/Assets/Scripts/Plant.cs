using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{

    public int plantMaxHealth = 30;
    public int plantMaxThirst = 30;
    public int currentHealth;
    public int currentThirst;

    public HealthBar healthbar;
    public ThirstBar thirstbar;

    void Start()
    {
        currentHealth = plantMaxHealth;
        currentThirst = plantMaxThirst;
        healthbar.SetMaxHealth(plantMaxHealth);
        thirstbar.SetMaxThirst(plantMaxThirst);
        InvokeRepeating("TriggerDamage", 0.5f, 0.5f);
        InvokeRepeating("TriggerThirst", 1f, 1f);
    }

    void Update()
    {
        if (currentHealth == 0 || currentThirst == 0)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    void TriggerDamage()
    {
        TakeDamage(1);
    }

    void TriggerThirst()
    {
        GetThirsty(1);
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);
    }

    void GetThirsty(int thirst)
    {
        currentThirst -= thirst;

        thirstbar.SetThirst(currentThirst);
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

    public void GainWater(int thirst)
    {
        currentThirst += thirst;
        if (currentThirst > 30)
        {
            currentThirst = 30;
        }

        thirstbar.SetThirst(currentThirst);
    }
}
