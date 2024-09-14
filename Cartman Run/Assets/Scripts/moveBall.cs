/*
 * CPI 211 Game Jam 1
 * - Jimmy Vongphosy 
 * 
 * Description: Script that allows player to move around
 * 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 2.5f;
    public float maxSpeed = 10.0f;
    private Rigidbody rb;      

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {        
        float moveHorizontal = Input.GetAxis("Horizontal");  // A/D or Left/Right
        float moveVertical = Input.GetAxis("Vertical");      // W/S or Up/Down

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
    }
}

