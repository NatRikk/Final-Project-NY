using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }

    public void UpdateHealthBar(int health)
    {
        slider.value = health;
        if (health > slider.maxValue * 0.5)
        {
            slider.fillRect.GetComponent<Image>().color = Color.green;
        }
        else if (health > slider.maxValue * 0.25)
        {
            slider.fillRect.GetComponent<Image>().color = Color.yellow;
        }
        else
        {
            slider.fillRect.GetComponent<Image>().color = Color.red;
        }
    }

}
