using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Slider healthBarGreen;
    public Slider healthBarRed;

    void Start()
    {
        currentHealth = maxHealth;
        // Initialize both health bars at the start
        healthBarGreen.maxValue = maxHealth;
        healthBarGreen.value = maxHealth;
        healthBarRed.maxValue = maxHealth;
        healthBarRed.value = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Max(currentHealth, 0);  // Prevent health from going below zero
        UpdateHealthBar();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void UpdateHealthBar()
    {
        healthBarGreen.value = currentHealth;
        // Optionally, delay the red health bar's decrease to visually indicate damage taken
        StartCoroutine(DelayedUpdateRedBar());
    }

    IEnumerator DelayedUpdateRedBar()
    {
        yield return new WaitForSeconds(0.5f);  // Delay for visual effect
        healthBarRed.value = currentHealth;
    }

    void Die()
    {
        Debug.Log("Player Died");
        gameObject.SetActive(false);  // Disable the player object
        // Additional death handling could go here
    }
}
