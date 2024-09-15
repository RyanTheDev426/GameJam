/*
 * CPI 211 Game Jam 1
 * - Jimmy Vongphosy 
 * 
 * Description: Script that created the 'bumper' functionalities for obstacles while ignoring the floor's collision
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounce : MonoBehaviour
{
    public float bounceForce = 10f;

    private void OnCollisionEnter(Collision collision)
    {
        Transform collidedTransform = collision.gameObject.transform;

        while (collidedTransform != null)
        {
            if (collidedTransform.CompareTag("Bumper")) //Issue: Collison keeps detecting parent object and not children tagged "Bumper"
            {
                Debug.Log("Collision detected with bumper: " + collidedTransform.name);
                Rigidbody rb = GetComponent<Rigidbody>();
                if (rb != null)
                {
                    Vector3 bounceDirection = collision.contacts[0].normal;
                    rb.AddForce(bounceDirection * bounceForce, ForceMode.Impulse);
                }
                return;
            }
            collidedTransform = collidedTransform.parent;
        }

        Debug.Log("Collision detected with: " + collision.gameObject.name);
    }
}



