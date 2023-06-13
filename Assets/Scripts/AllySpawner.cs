using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllySpawner : MonoBehaviour
{   
    // Defence drone reference
    public GameObject allyDrone;
    
    // Next spawn point
    float nextSpawn;

    // Set of vectors to spawn drones
    Vector3[] whereToSpawn = new Vector3[6] {   
                                                new Vector3(-30f, 0f, -45f), 
                                                new Vector3(-25f, 0f, -45f), 
                                                new Vector3(-20f, 0f, -45f), 
                                                new Vector3(-30f, 0f, -45f), 
                                                new Vector3(-25f, 0f, -45f), 
                                                new Vector3(-20f, 0f, -45f) 
                                            };
    // Minimal drone count
    private float minDroneCount  = 3;

    // Actual drone count
    private float totalAllyDroneCount = infoHandler.AllyDroneCount;

    // Parent drone to spawn copies
    public GameObject parentDrone;
    
    // Start is called before the first frame update
    void Start()
    {
        // Drone spawn logic
        switch (totalAllyDroneCount)
        {
            case 3:
                break;
            case 4:
                spawn(4f);
                break;
            case 5:
                spawn(5f);
                break;
            case 6:
                spawn(6f);
                break;
            default: break;
        }
    }

    // Drone spawn mechanic
    public void spawn (float droneCount)
    {   
   
            for (int i = 0; i < totalAllyDroneCount - minDroneCount; i++)
                
                {   
                    // Spawning a drone
                    GameObject AllyDrone = Instantiate(allyDrone, whereToSpawn[i+1], Quaternion.identity);
                    
                }

    }

    // Destroying overcounted drones
    private void destroyDrone(float totalDrone, float droneCur)
    {
        
        for (int i = 0; i < totalDrone - droneCur; i++)

        {
            GameObject missingDrone = GameObject.FindWithTag("AllyDrone");
            if (missingDrone != null)
            Destroy(missingDrone);

        }

    }
}
