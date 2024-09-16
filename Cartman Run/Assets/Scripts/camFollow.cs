using UnityEngine;

public class camFollow : MonoBehaviour
{
    public Transform player; // The player's transform
    public Vector3 offset;   // Offset if needed

    void LateUpdate()
    {
        // Update the position to match the player's position plus offset
        transform.position = player.position + offset;

        // Lock the rotation to face upwards
        transform.rotation = Quaternion.Euler(90f, 0f, 0f);
    }
}
