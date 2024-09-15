using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltPlatform : MonoBehaviour
{
    public Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private int timer = 0;
    private bool canRotate = true;
    void Rotate()
    {
        if (Input.GetAxis("HorizontalKey") > 0.2)
        {
            if (rotation.z >= 344 || rotation.z <= 15)
            {
                transform.Rotate(0f, 0f, 0.27f);
            }
        }
        if (Input.GetAxis("HorizontalKey") < -0.2)
        {
            if (rotation.z <= 16 || rotation.z >= 345)
            {
                transform.Rotate(0f, 0f, -0.27f);
            }
        }
        if (Input.GetAxis("VerticalKey") > 0.2)
        {
            if (rotation.x >= 345 || rotation.x <= 16) 
            {
                transform.Rotate(-0.27f, 0f, 0f);
            }
        }
        if (Input.GetAxis("VerticalKey") < -0.2)
        {
            if (rotation.x >= 344 || rotation.x <= 15)
            {
                transform.Rotate(0.27f, 0f, 0f);
            }
        }
    }
    void Update()
    {
        rotation = GetComponent<Transform>().eulerAngles;
        timer++;
        if (canRotate) {
            Rotate();
            canRotate = false;
        }
        if(timer >= 5)
        {
            canRotate = true;
            timer = 0;
        }
        transform.Rotate(0, -rotation.y, 0);
        if (Input.GetKeyDown("r"))
        {
            transform.Rotate(-rotation.x, 0, -rotation.z);
            timer = 0;
        }
    }
}
