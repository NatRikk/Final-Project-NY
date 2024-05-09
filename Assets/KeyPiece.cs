using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            KeyManager.instance.AddKey();
            Destroy(gameObject); // Destroy the key
        }
    }
}
