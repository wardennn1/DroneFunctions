using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllySpawner : MonoBehaviour
{   
    // ќбразец оборонительного дрона дл€ спауна
    public GameObject allyDrone;
    
    // —ледующа€ точка спауна
    float nextSpawn;

    // Ќабор векторов дл€ расположени€ оборонительных дронов
    Vector3[] whereToSpawn = new Vector3[6] {   
                                                new Vector3(-30f, 0f, -45f), 
                                                new Vector3(-25f, 0f, -45f), 
                                                new Vector3(-20f, 0f, -45f), 
                                                new Vector3(-30f, 0f, -45f), 
                                                new Vector3(-25f, 0f, -45f), 
                                                new Vector3(-20f, 0f, -45f) 
                                            };
    // ћинимальное количество оборонительных дронов
    private float minDroneCount  = 3;

    //јктуальное количество оборонительных дронов
    private float totalAllyDroneCount = infoHandler.AllyDroneCount;

    // –одительский оборонительый дрон дл€ ориентации при динамическом спауне
    public GameObject parentDrone;
    
    // Start is called before the first frame update
    void Start()
    {
        // Ћогика расположени€ недостающих оборонительных дронов
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

    // —оздание недостающих оборонительных дронов
    public void spawn (float droneCount)
    {   
   
            for (int i = 0; i < totalAllyDroneCount - minDroneCount; i++)
                
                {   
                    // –асположение недостающего оборонительного дрона
                    GameObject AllyDrone = Instantiate(allyDrone, whereToSpawn[i+1], Quaternion.identity);
                    
                }

    }

    // ”даление излишних оборонительных дронов
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
