using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weatherControl : MonoBehaviour
{
    /// <summary>
    /// ѕеременна€ - режим погоды 
    /// 0 - стандартна€ погода
    /// 1 - туман
    /// 2 - ветер (в разработке)
    /// </summary>
    private float wMode = infoHandler.WeatherMode;
    // Start is called before the first frame update
    void Start()
    {
        // ѕроверка режима погоды
        switch (wMode)
        {
            case 0:
                break;

            case 1:
                RenderSettings.fog = true; 
                break;

            case 2:
                RenderSettings.fog = false; 
                break;

            default: 
                break;
        }

    }
   
}
