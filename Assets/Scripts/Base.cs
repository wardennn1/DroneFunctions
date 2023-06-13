using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{   

    // Стандартные значения здоровья и максимального здоровья
    [SerializeField] public float health, maxHealth = 500;

    //Назначение полоски здоровья
    [SerializeField] FloatingHealthBar healthBar;
    
    // Получение урона объектом
        public void TakeDamage (float damageAmount)
        {
            health -= damageAmount;
            healthBar.UpdateHealthBar(health,maxHealth);
        
            // Проверка количества здоровья на момент летальности нанесенного урона
            if (health <= 0)
            {   
                Die();
            }
        }

        // Уничтожение игрового объекта - базы 
            public void Die()
        {
            Destroy(gameObject);
        }
}
