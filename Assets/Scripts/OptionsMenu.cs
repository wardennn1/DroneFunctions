using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    // Reference to options menu object
    public GameObject optionsObject;
    public bool EscapeMenuOpen;

    // Update is called once per frame
    void Update()
    {   

        // Listening to escape button to activate options menu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (EscapeMenuOpen == false)
            {
                EscapeMenuOpen = true;
                optionsObject.SetActive(true);
            }

            else
            {
                EscapeMenuOpen = false;
                optionsObject.SetActive(false);
            }
        }   
    }

    // Contnue modeling
    public void continueMod()
    {   
        EscapeMenuOpen = false;
        optionsObject.SetActive(false);
    }

    // Back to main menu
    public void backToMenu()
    {   
        // Setting default environment parameters
        infoHandler.AllyDroneCount = 3;
        infoHandler.EnemyDroneCount = 3;
        infoHandler.WeatherMode = 0;
        SceneManager.LoadScene(0);
    }

}
