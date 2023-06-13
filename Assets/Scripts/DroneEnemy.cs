using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneEnemy : MonoBehaviour
{   
    // Скорость перемещения дрона
    public float Speed = 0f;

    // Длина луча стрельбы
    public float raycastLength = 10f;
    
    // Сила подъема дрона в воздух
    float upForce;
    private Rigidbody _rb;
    
    // Стандартные значения максимального и текущего здоровья
    [SerializeField] public float health, maxHealth = 100f;

    // Поле для элемента полоски здоровья
    [SerializeField] FloatingHealthBar healthBar;
    
    RaycastHit hit;


    // Определение элементов и характеристик дрона
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        health = maxHealth;
        healthBar.UpdateHealthBar(health,maxHealth);
        healthBar = GetComponentInChildren<FloatingHealthBar>();
    }

    // Покадровая обработка состояния дрона
    void FixedUpdate()
    {   
        // Применение силы для подъема дрона в воздух
        _rb.AddRelativeForce(Vector3.up * upForce);
                
        Ray ray = new Ray (transform.position, -transform.up);

        // Перемещение дрона
        MovementLogic ();
        

    }

    // Логика перемещения дрона (не для демонстрации)
    private void MovementLogic ()
    {   
        /// Считывание клавиш управления дроном в осях x z
        // float moveHorizontal = Input.GetAxis("Horizontal");
        // float moveVertical = Input.GetAxis("Vertical");

        /// Обработка нажатия клавиш для подъема или снижения дрона
        // if(Input.GetKey(KeyCode.LeftShift))
        //     {
        //         upForce = 8f;
        //     } 
        // else if (Input.GetKey(KeyCode.LeftControl))
        //     {
        //         upForce = -8f;
        //     } 
        // else if(!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.LeftControl))
        //     {
        //         upForce = 0f;
        //     }
        // Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        ///Применение силы для подъема или снижения дрона
        // _rb.AddRelativeForce(movement * Speed);

    }

    // Получение урона дроном
    public void TakeDamage (float damageAmount)
    {   

        // Изменение значения здоровья дрона
        health -= damageAmount;
        healthBar.UpdateHealthBar(health,maxHealth);

        // Проверка на условие летальности полученного урона
        if (health <= 0)
        {   
            Die();
        }
    }

    // Самоуничтожение дрона
    public void Die()
    {
        Destroy(gameObject);
    }

}

