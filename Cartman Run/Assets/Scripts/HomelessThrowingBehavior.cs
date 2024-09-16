using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomelessThrowingBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("FirstHomeless") && FindObjectOfType<HomelessScript>().homelessDeployed >= 1)
        {
            
        }
        else if (gameObject.CompareTag("SecondHomeless") && FindObjectOfType<HomelessScript>().homelessDeployed >= 2)
        {

        }
        else if (gameObject.CompareTag("AussieHomeless") && FindObjectOfType<HomelessScript>().homelessDeployed >= 1)
        {

        }
    }
}
