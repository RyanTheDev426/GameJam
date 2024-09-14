/*
 * CPI 211 Game Jam 1
 * - Jimmy Vongphosy 
 * 
 * Description: Camera follow script for object
 * 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform lookAt;
    private Vector3 previousPos;

    void Start()
    {
        previousPos = lookAt.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 deltaPos = lookAt.position - previousPos;
        transform.position += deltaPos;

        previousPos = lookAt.position;
    }
}
