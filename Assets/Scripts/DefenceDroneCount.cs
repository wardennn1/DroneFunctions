using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DefenceDroneCount : MonoBehaviour
{
    // Обработчик нажатий в элементе смены количества оборонительных дронов 
    public void DropdownHandler(int index){
        
        // Логика выбора количества оборонительных дронов
        switch (index)
        {
            case 0: infoHandler.AllyDroneCount = 3; 
                break;

            case 1: infoHandler.AllyDroneCount = 4; 
                break;

            case 2: infoHandler.AllyDroneCount = 5; 
                break;

            case 3: infoHandler.AllyDroneCount = 6; 
                break;

            default: 
                break;
        }
    }

}
