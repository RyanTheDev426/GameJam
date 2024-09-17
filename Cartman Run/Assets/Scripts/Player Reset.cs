using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReset : MonoBehaviour
{
    public Vector3 position;
    public Rigidbody rBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position = GetComponent<Transform>().position;
        if (Input.GetKeyDown("r"))
        {
            transform.position = new Vector3(0f, 1f, 0f);
            rBody.isKinematic = true;
            rBody.isKinematic = false;
        }
    }
}
