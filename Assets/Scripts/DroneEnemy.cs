using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneEnemy : MonoBehaviour
{   
    // Drone move speed
    public float Speed = 0f;

    // Drone's shooting range
    public float raycastLength = 10f;
    
    // Force to up drone
    float upForce;
    private Rigidbody _rb;
    
    // Default HP
    [SerializeField] public float health, maxHealth = 100f;

    // Reference to healthbar-element
    [SerializeField] FloatingHealthBar healthBar;
    
    RaycastHit hit;


    // Initializing default parameters
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        health = maxHealth;
        healthBar.UpdateHealthBar(health,maxHealth);
        healthBar = GetComponentInChildren<FloatingHealthBar>();
    }

    // Checking move commands
    void FixedUpdate()
    {   
        // Adding force to up drone
        _rb.AddRelativeForce(Vector3.up * upForce);
                
        Ray ray = new Ray (transform.position, -transform.up);

        // Checking movement commands
        MovementLogic ();
        

    }

    // Drone movement logics
    private void MovementLogic ()
    {   
        /// ���������� ������ ���������� ������ � ���� x z
        // float moveHorizontal = Input.GetAxis("Horizontal");
        // float moveVertical = Input.GetAxis("Vertical");

        /// ��������� ������� ������ ��� ������� ��� �������� �����
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

        ///���������� ���� ��� ������� ��� �������� �����
        // _rb.AddRelativeForce(movement * Speed);

    }

    // Taking damage mechanics
    public void TakeDamage (float damageAmount)
    {   

        // Changin HP amount
        health -= damageAmount;
        healthBar.UpdateHealthBar(health,maxHealth);

        // Checking letal damage
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

