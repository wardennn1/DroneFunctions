using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weatherControl : MonoBehaviour
{
    /// <summary>
    /// Parameters to switch weather mode
    /// 0 - Default weather
    /// 1 - Fog
    /// 2 - ����� (� ����������)
    /// </summary>
    private float wMode = infoHandler.WeatherMode;
    // Start is called before the first frame update
    void Start()
    {
        // �������� ������ ������
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
