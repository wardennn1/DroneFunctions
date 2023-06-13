using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{   
    // Parent drone to copy
    public GameObject enemyDrone;
    
    // Positions to spawn drones
    Vector3[] whereToSpawn = new Vector3[6] {   
                                                new Vector3(-20f, 0f, 5f), 
                                                new Vector3(-25f, 0f, 5f), 
                                                new Vector3(-30f, 0f, 5f), 
                                                new Vector3(-20f, 0f, 5f), 
                                                new Vector3(-25f, 0f, 13f), 
                                                new Vector3(-30f, 0f, 13f) 
                                            };
    
    // Minimal drone count
    private float minDroneCount = 3;
    
    // Actual attack drone count
    private float totalEnemyDroneCount = infoHandler.EnemyDroneCount; 

    public GameObject parentDrone; //������������ ����

    // Start is called before the first frame update
    void Start()
    {   
        // Spawn logic
        switch (totalEnemyDroneCount)
        {
            case 3:
                break;

            case 4:
                spawn(4);
                break;

            case 5:
                spawn(5);
                break;

            case 6:
                spawn(6);
                break;

            default: 
                break;
        }
    }

    // Spawn mechanic
    public void spawn (float droneCount)
    {   
        
            for (int i = 0; i <  totalEnemyDroneCount - minDroneCount; i++)
                
                {   
                    // Adding new drone
                    GameObject AllyDrone = Instantiate(enemyDrone, whereToSpawn[i+1], Quaternion.identity);
                }

    }

    // Destroying drone
    private void destroyDrone(float totalDrone, float droneCur)
    {
        
        for (int i = 0; i < totalDrone - droneCur; i++)

        {
            GameObject missingDrone = GameObject.FindWithTag("EnemyDrone");
            if (missingDrone != null)
                Destroy(missingDrone);

        }

    }
}
