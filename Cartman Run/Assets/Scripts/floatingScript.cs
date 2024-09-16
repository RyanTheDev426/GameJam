/*
 * CPI 211 Game Jam 1
 * - Jimmy Vongphosy 
 * 
 * Description: Script floats and spins an object (Used for collectibles)
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatEffect : MonoBehaviour
{
    public float amp = 0.5f;
    public float freq = 1f;
    public float rotateSpeed = 30f;

    private Vector3 localStartPos;
    private Transform platform;

    void Start()
    {
        platform = transform.parent;
        localStartPos = transform.localPosition;
    }

    void Update()
    {
        //Float effect
        float y = Mathf.Sin(Time.time * freq) * amp;
        transform.position = localStartPos + new Vector3(0,y,0);

        //Spin effect
        float rotateAmount = rotateSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, rotateAmount);
    }

}