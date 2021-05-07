using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 10;
    public int currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    
    void Update()
    {
        if (currentHealth == 0)
        {
            Destroy(gameObject);
        }

    }
    

    private void OnTriggerEnter2D(Collider2D obstacle)
    {
        if (obstacle.tag == "Obstacle")
        {
            TakeDamage(1);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}

