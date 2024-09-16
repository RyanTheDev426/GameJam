using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BoomerangBehavior : MonoBehaviour
{
    float moveSpeed = 5f;
    float timer = 30f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        transform.LookAt(playerObject.transform.position);
    }
    void Update()
    {
        timer--;
        if(timer > 0)
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
            transform.LookAt(playerObject.transform.position);
        }
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }
    void OnColliderEnter(Collider other)
    {
        if (other.CompareTag("Terrain"))
        {
            Destroy(gameObject);
        }
        else if (other.CompareTag("Player"))
        {
            //Remove Hp/kill cartman command, then delete this rock.
        }
    }
}

