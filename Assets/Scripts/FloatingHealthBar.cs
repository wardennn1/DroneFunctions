using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingHealthBar : MonoBehaviour
{
    // Parameters to change with healthbar
    [SerializeField] private Slider slider;
    [SerializeField] private Camera camera;
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;

    // Displaying change of HP amount
    public void UpdateHealthBar (float currentValue, float maxValue)
    {   
        slider.value = currentValue / maxValue;
    }

    // Moving healthbar with camera's changing position
    void Update()
    {
        transform.rotation = camera.transform.rotation;
        transform.position = target.position + offset;

    }
}
