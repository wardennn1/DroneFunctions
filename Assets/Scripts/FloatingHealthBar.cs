using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingHealthBar : MonoBehaviour
{
    // Поля для работы с объектом наложения элемента полоски здоровья
    [SerializeField] private Slider slider;
    [SerializeField] private Camera camera;
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;

    // Изменение состояния полоски здоровья
    public void UpdateHealthBar (float currentValue, float maxValue)
    {   
        slider.value = currentValue / maxValue;
    }

    // Перемещение полоски здоровья в зависимости от расположения камеры
    void Update()
    {
        transform.rotation = camera.transform.rotation;
        transform.position = target.position + offset;

    }
}
