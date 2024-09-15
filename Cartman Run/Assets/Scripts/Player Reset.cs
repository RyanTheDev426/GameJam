using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReset : MonoBehaviour
{
    public Vector3 position;
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
            transform.position = new Vector3(position.x, 1f, position.z);
        }
    }
}
