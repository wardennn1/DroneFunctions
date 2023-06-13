using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DefenceDroneCount : MonoBehaviour
{
    // Listening to defence drone count element
    public void DropdownHandler(int index){
        
        // Defence drone count logic
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
