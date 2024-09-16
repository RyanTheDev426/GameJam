using UnityEngine;

public class MinimapIconFollow : MonoBehaviour
{
    public Transform target; // The object to follow

    void LateUpdate()
    {
        // Keep the empty GameObject at the target's position
        transform.localPosition = target.position;

        // Ensure the icon always faces upwards
        transform.rotation = Quaternion.Euler(90f, 0f, 0f);
    }
}
