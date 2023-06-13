using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    // Меню опций
    public GameObject optionsObject;
    public bool EscapeMenuOpen;

    // Update is called once per frame
    void Update()
    {   

        // Обработка нажатия клавиши Escape для вызова меню опций
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

    // Обработка нажатия кнопки продолжения моделирования
    public void continueMod()
    {   
        EscapeMenuOpen = false;
        optionsObject.SetActive(false);
    }

    //Обработка нажатия кнопки возврата в главное меню
    public void backToMenu()
    {   
        // Устоановка глобальных параметров на изначальные значения
        infoHandler.AllyDroneCount = 3;
        infoHandler.EnemyDroneCount = 3;
        infoHandler.WeatherMode = 0;
        SceneManager.LoadScene(0);
    }

}
