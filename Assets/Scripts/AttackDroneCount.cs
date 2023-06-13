using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AttackDroneCount : MonoBehaviour
{   
    // Спаунер атакующих дронов
    public EnemySpawner enemySpawner;

    // Обработка элемента выбора количества атакующих дронов
    public void DropdownHandler(int index){
        
        // Логика установки количества атакующих дронов
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
