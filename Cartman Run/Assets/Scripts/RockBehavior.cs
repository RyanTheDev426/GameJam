using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class RockBehavior : MonoBehaviour
{
    float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        transform.LookAt(playerObject.transform.position);
    }
    void Update()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }
    void OnColliderEnter(Collider other)
    {
        if(other.CompareTag("Terrain"))
        {
            Destroy(gameObject);
        }
        else if(other.CompareTag("Player"))
        {
            //Remove Hp/kill cartman command, then delete this rock.
        }
    }
}
