using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAlly : MonoBehaviour
{
    // Скорость полета дрона
    public float Speed = 10f;
    
    // Длина луча атаки
    public float raycastLength = 10f;
    
    //Сила подъема дрона вверх
    float upForce;
    
    private Rigidbody _rb;
    
    // Урон дрона
    public float damage = 10f;
 
    public float range = 10f;
    
    // Стандартные значения максимального и текущего здоровья
    [SerializeField] float health, maxHealth = 100f;

    // Поле для элемента полоски здоровья
    [SerializeField] FloatingHealthBar healthBar;
    
    // Переменная с данными об объекте попадания
    RaycastHit hit;


    // Определение стандартных компонент при старте сцены
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        health = maxHealth;
        healthBar.UpdateHealthBar(health,maxHealth);
        healthBar = GetComponentInChildren<FloatingHealthBar>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        // Придача дрону силы для взлёта
        _rb.AddRelativeForce(Vector3.up * upForce);
                
        // Перемещение дрона
        MovementLogic ();

    }


    void Update() 
    {   
        // Проверка нажатия кнопки стрельбы
        if (Input.GetButtonDown("Fire1"))
        {   
            // Стрельба
            Shoot();
        }
    }

    // Логика полета дрона
    private void MovementLogic ()
    {   

        // Считывание клавиш управления в плоскостях x z
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Обработка нажатия клавиш для взлета и снижения
        if(Input.GetKey(KeyCode.LeftShift))
            {
                upForce = 8f;
            } 
        else if (Input.GetKey(KeyCode.LeftControl))
            {
                upForce = -8f;
            } 
        else if(!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.LeftControl))
            {
                upForce = 0f;
            }
        
        // Задание нового вектора перемещения для дрона после обработки клавищ
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        _rb.AddRelativeForce(movement * Speed);

    }


    // Получение урона
    public void TakeDamage (float damageAmount)
    {   
        // Изменение показателей здоровья дрона
        health -= damageAmount;
        healthBar.UpdateHealthBar(health,maxHealth);

        // Проверка условия получения летального урона
        if (health <= 0)
        {   
            Die();
        }
    }

    // Уничтожение дрона
    public void Die()
    {

    }


    // Стрельба
    public void Shoot ()
    {   
        
        // Обработка попадания лучом по объекту
        RaycastHit shootHit;
        if (Physics.Raycast(_rb.transform.position, _rb.transform.forward, out shootHit, range ))
        {
            DroneEnemy droneEnemy = shootHit.transform.GetComponent<DroneEnemy>();

            // Проверка попадания по вражескому дрону
            if (droneEnemy != null)
            {   
                droneEnemy.TakeDamage(damage);
                
            }

            Base baseTarget = shootHit.transform.GetComponent<Base>();

            // Проверка попадания по базе противника
            if (baseTarget != null)
            {   
                
                baseTarget.TakeDamage(damage);
            }


        }
    }

}
