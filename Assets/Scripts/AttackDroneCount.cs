using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AttackDroneCount : MonoBehaviour
{   
    // Reference to attack drone spawner
    public EnemySpawner enemySpawner;

    // Listening attack drone count element
    public void DropdownHandler(int index){
        
        // Attack drone count logic
        switch (index)
        {   
            case 0: 
                infoHandler.EnemyDroneCount = 3; 
                break;

            case 1: 
                infoHandler.EnemyDroneCount = 4; 
                break;

            case 2: 
                infoHandler.EnemyDroneCount = 5; 
                break;

            case 3: 
                infoHandler.EnemyDroneCount = 6; 
                break;

            default: 
                break;
        }
    }

}
