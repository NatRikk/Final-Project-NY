using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float smoothSpeed = 0.125f; // How smoothly the camera catches up with its target movement
    public Vector3 offset; // Offset position from the player

    void FixedUpdate()
    {
        if (player != null)
        {
            Vector3 desiredPosition = player.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            // Optionally, set the camera's Z position to a fixed value, e.g., -10
            transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        }
    }
}
