using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherMode : MonoBehaviour
{
    // Start is called before the first frame update
    public void DropdownHandler(int index)
    {
        switch (index)
        {
            case 0: infoHandler.WeatherMode = 0; break;
            case 1: infoHandler.WeatherMode = 1; break;
            //case 2: infoHandler.WeatherMode = 2; break;
            default: break;

        }
        
    }
}
