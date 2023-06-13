using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{   

    // Скорость перемещения камеры
    public float camSpeed = 20;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        // Движение камеры вперед
        if (Input.GetKey(KeyCode.W))
            {
                pos.z += camSpeed * Time.deltaTime;
            }
        
        // Движение камеры назад
        if (Input.GetKey(KeyCode.S))
            {
                pos.z -= camSpeed * Time.deltaTime;
            }

        // Движение камеры вправо
        if (Input.GetKey(KeyCode.D))
            {
                pos.x += camSpeed * Time.deltaTime;
            }

        // Движение камеры влево
        if (Input.GetKey(KeyCode.A))
            {
                pos.x -= camSpeed * Time.deltaTime;
            }
        
        // Подъем камеры 
        if (Input.GetKey(KeyCode.RightShift))
        {
            pos.y += camSpeed * Time.deltaTime;
        }

        // Снижение камеры
        if (Input.GetKey(KeyCode.RightControl))
        {
            pos.y -= camSpeed * Time.deltaTime; 
        }

        // Смещение камеры
        transform.position = pos;

    }
}
