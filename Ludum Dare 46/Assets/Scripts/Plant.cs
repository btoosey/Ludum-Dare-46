﻿using System.Collections;
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
        InvokeRepeating("TriggerDamage", 1f, 1f);
        InvokeRepeating("TriggerThirst", 2f, 2f);
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
}
