using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{   

    // Camera move speed
    public float camSpeed = 20;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        // Camera move forward
        if (Input.GetKey(KeyCode.W))
            {
                pos.z += camSpeed * Time.deltaTime;
            }
        
        // Camera move backward
        if (Input.GetKey(KeyCode.S))
            {
                pos.z -= camSpeed * Time.deltaTime;
            }

        // Camera move right
        if (Input.GetKey(KeyCode.D))
            {
                pos.x += camSpeed * Time.deltaTime;
            }

        // Camera move left
        if (Input.GetKey(KeyCode.A))
            {
                pos.x -= camSpeed * Time.deltaTime;
            }
        
        // Camera move up
        if (Input.GetKey(KeyCode.RightShift))
        {
            pos.y += camSpeed * Time.deltaTime;
        }

        // Camera move down
        if (Input.GetKey(KeyCode.RightControl))
        {
            pos.y -= camSpeed * Time.deltaTime; 
        }

        // Resulting camera move
        transform.position = pos;

    }
}
