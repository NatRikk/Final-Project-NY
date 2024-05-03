using UnityEngine;
using UnityEngine.UI;

public class KeyManager : MonoBehaviour
{
    public static KeyManager instance;
    public int keysCollected = 0;
    public Text winText;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void AddKey()
    {
        keysCollected++;
        if (keysCollected >= 4)
        {
            winText.text = "Congratulations You Escaped";
        }
    }
}
