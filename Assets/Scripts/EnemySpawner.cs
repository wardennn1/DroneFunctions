using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{   
    // ќбразец дрона дл€ спауна
    public GameObject enemyDrone;
    
    // Ќабор векторов дл€ расположени€ недостающих атакующих дронов
    Vector3[] whereToSpawn = new Vector3[6] {   
                                                new Vector3(-20f, 0f, 5f), 
                                                new Vector3(-25f, 0f, 5f), 
                                                new Vector3(-30f, 0f, 5f), 
                                                new Vector3(-20f, 0f, 5f), 
                                                new Vector3(-25f, 0f, 13f), 
                                                new Vector3(-30f, 0f, 13f) 
                                            };
    
    // ћинимальное количество атакующих дронов
    private float minDroneCount = 3;
    
    //  оличество атакующих дронов
    private float totalEnemyDroneCount = infoHandler.EnemyDroneCount; 

    public GameObject parentDrone; //–одительский дрон

    // Start is called before the first frame update
    void Start()
    {   
        // Ћогика расположени€ недостающих дронов
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

    // —озданиие недостающих дронов
    public void spawn (float droneCount)
    {   
        
            for (int i = 0; i <  totalEnemyDroneCount - minDroneCount; i++)
                
                {   
                    // –асположение недостающего атакующего дрона
                    GameObject AllyDrone = Instantiate(enemyDrone, whereToSpawn[i+1], Quaternion.identity);
                }

    }

    // ”даление излишних атакующих дронов
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
