using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomerangBehavior : MonoBehaviour
{
    float moveSpeed = 10f;
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
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision indeed");
        if (other.CompareTag("Terrain") || other.CompareTag("Bumper"))
        {
            gameObject.transform.position = new Vector3(300f, 300f, 300f);
            moving = false;
        }
        else if (other.CompareTag("Player"))
        {
            gameObject.transform.position = new Vector3(300f, 300f, 300f);
            PlayerHP health = FindObjectOfType<PlayerHP>();
            health.HP--;
            moving = false;
        }
    }
}

