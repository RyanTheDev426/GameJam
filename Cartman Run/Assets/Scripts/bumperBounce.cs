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

public class bumperBounce : MonoBehaviour
{
    public float bounceForce = 1000f; //Bump power

    private void OnCollisionEnter(Collision other)
    {

        GameObject otherObject  = other.gameObject;

        if (otherObject.CompareTag("Player"))
        {
            Debug.Log("Collision detected with bumper: " + other.gameObject.name); //Debug purpose

            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 bounceDirection = other.contacts[0].normal;
                rb.AddForce(bounceDirection * bounceForce, ForceMode.Impulse);
            }
        }
    }
 }



