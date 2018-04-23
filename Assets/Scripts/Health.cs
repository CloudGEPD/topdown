using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int max_health;

    private int currentHealth;

    private void Start()
    {
        ResetHealth();
    }

    private void ResetHealth()
    {
        currentHealth = max_health;
    }

    public void TookDamage(int damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            Death();
        }

    }

    private void Death()
    {
        Destroy(gameObject);
    }
}
