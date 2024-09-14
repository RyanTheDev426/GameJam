using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 rockVelocity = new Vector3(10, 0, 0);

        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        transform.LookAt(playerObject.transform.position);

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