using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BoomerangBehavior : MonoBehaviour
{
    float moveSpeed = 5f;
    public Boolean rockThrown = false;
    Boolean moving = false;
    float timer = 250f;
    void Update()
    {
        if (rockThrown == true)
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
            transform.LookAt(playerObject.transform.position);
            rockThrown = false;
            moving = true;
        }
        if (moving == true)
        {
            if(timer > 0)
            {
                timer--;
                GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
                transform.LookAt(playerObject.transform.position);
            }
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }

    }
    void OnColliderEnter(Collider other)
    {
        if (other.CompareTag("Terrain") || other.CompareTag("Bumper"))
        {
            transform.position = new Vector3(300, 300, 300);
            moving = false;
        }
        else if (other.CompareTag("Player"))
        {
            //Remove Hp/kill cartman command, then delete this rock.
        }
    }
}

