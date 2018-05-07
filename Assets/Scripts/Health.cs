using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int max_health;
    //Attributes
   [HideInInspector]
    public bool isDead;

    Animator animator;
    private int currentHealth;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
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
        animator.SetBool("IsDead", true);
        isDead = true;
        Destroy(gameObject, 5f);
    }
}
