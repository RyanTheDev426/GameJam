/*
 * CPI 211 Game Jam 1
 * - Jimmy Vongphosy 
 * 
 * Description: Script that created the 'bumper' functionalities for obstacles
 * 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceOnCollision : MonoBehaviour
{
    public float bounceForce = 10f; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) //If player tag
        {
            Debug.Log("Player Touched Bumper"); //Known issue: Collision now detected

            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                Vector3 bounceDir = collision.contacts[0].normal;

                rb.AddForce(bounceDir * bounceForce, ForceMode.Impulse);
            }
        }
    }
}

