using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public static KeyManager instance;
    public int keysCollected = 0;
    public GameObject menuPanel; // Assign this from the inspector
    public int requiredKeys = 3;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Keep instance across scenes
        }
    }

    public void AddKey()
    {
        keysCollected++;
        Debug.Log("Key collected! Total keys: " + keysCollected);

        if (keysCollected >= requiredKeys)
        {
            ShowMenu();
        }
    }

    void ShowMenu()
    {
        if (menuPanel != null)
        {
            menuPanel.SetActive(true);
            Debug.Log("Menu should now be visible.");
        }
        else
        {
            Debug.LogError("Menu panel is not assigned in KeyManager.");
        }
    }
}
