using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{   

    // Default HP 
    [SerializeField] public float health, maxHealth = 500;

    // Reference to healthbar element
    [SerializeField] FloatingHealthBar healthBar;
    
    // Damage taking mechanic
        public void TakeDamage (float damageAmount)
        {
            health -= damageAmount;
            healthBar.UpdateHealthBar(health,maxHealth);
        
            // Letal damage checking
            if (health <= 0)
            {   
                Die();
            }
        }

        // Death mechanic
            public void Die()
        {
            Destroy(gameObject);
        }
}
