using UnityEngine;

public class iconRotation : MonoBehaviour
{
    void LateUpdate()
    {
        // Reset the world rotation to face upwards
        transform.rotation = Quaternion.Euler(90f, 0f, 0f);
    }
}
