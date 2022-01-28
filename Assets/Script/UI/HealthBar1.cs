using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//fait par Lucas

public class HealthBar1 : MonoBehaviour
{
    public Slider slider;
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    public void SetHealth(int health)
    {
        slider.value =health;
    }
}
