using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAlly : MonoBehaviour
{
    // Drone move speed
    public float Speed = 10f;
    
    // Drone's ray shoot range
    public float raycastLength = 10f;
    
    // Force to up drone
    float upForce;
    
    private Rigidbody _rb;
    
    // Drone damage
    public float damage = 10f;
 
    public float range = 10f;
    
    // Default HP
    [SerializeField] float health, maxHealth = 100f;

    // Reference to healthbar element
    [SerializeField] FloatingHealthBar healthBar;
    
    // hit info variable
    RaycastHit hit;


    // Default parameters initializing
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
        // Force to up drone
        _rb.AddRelativeForce(Vector3.up * upForce);
                
        // Logic of drone movement
        MovementLogic ();

    }


    void Update() 
    {   
        // Listening to fire button
        if (Input.GetButtonDown("Fire1"))
        {   
            // Shooting
            Shoot();
        }
    }

    // Drone movement logic
    private void MovementLogic ()
    {   

        // Drone moving in axys X and Z
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Listening to up/down commands
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
        
        // Resulting drone movement
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        _rb.AddRelativeForce(movement * Speed);

    }


    // Damage taking mechanic
    public void TakeDamage (float damageAmount)
    {   
        // Changing hp 
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

    }


    // Shoot mechanic
    public void Shoot ()
    {   
        
        // Checking hit target
        RaycastHit shootHit;
        if (Physics.Raycast(_rb.transform.position, _rb.transform.forward, out shootHit, range ))
        {
            DroneEnemy droneEnemy = shootHit.transform.GetComponent<DroneEnemy>();

            // Dealing damage to enemy drone
            if (droneEnemy != null)
            {   
                droneEnemy.TakeDamage(damage);
                
            }

            Base baseTarget = shootHit.transform.GetComponent<Base>();

            // Dealing damage to enemy base
            if (baseTarget != null)
            {   
                
                baseTarget.TakeDamage(damage);
            }


        }
    }

}
