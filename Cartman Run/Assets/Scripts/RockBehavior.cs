using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class RockBehavior : MonoBehaviour
{
    float moveSpeed = 5f;
    public Boolean rockThrown = false;
    Boolean moving = false;
    void Update()
    {
        if(rockThrown == true)
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
            transform.LookAt(playerObject.transform.position);
            rockThrown = false;
            moving = true;
        }
        if(moving == true)
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
        
    }
    void OnColliderEnter(Collider other)
    {
        if(other.CompareTag("Terrain") || other.CompareTag("Bumper"))
        {
            transform.position = new Vector3(300, 300, 300);
            moving = false;
        }
        else if(other.CompareTag("Player"))
        {
            //Remove Hp/kill cartman command, then delete this rock.
        }
    }
}
