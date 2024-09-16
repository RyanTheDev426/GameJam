using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform player; // Reference to the player's Transform
    public Vector3 offset;   // Offset from the player's position

    void LateUpdate()
    {
        // Update the camera's position to follow the player
        transform.position = player.position + offset;

        // Keep the camera's rotation fixed
        transform.rotation = Quaternion.Euler(90f, 0f, 0f); // Looking straight down
    }
}
