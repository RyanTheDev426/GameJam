/*
 * CPI 211 Game Jam 1
 * - Jimmy Vongphosy 
 * 
 * Description: Script that allows player to collect an object/collectible
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibleScript : MonoBehaviour
{
    public int hats = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            Debug.Log("Collected");
            Debug.Log(hats);
            Destroy(other.gameObject);
            hats++;
        }
    }
}
