using UnityEngine;

public class KeyPiece : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            KeyManager.instance.AddKey();
            Destroy(gameObject); // This destroys the key piece when collected
        }
    }
}
