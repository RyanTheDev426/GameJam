using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomelessScript : MonoBehaviour
{
    public collectibleScript hat;
    public int homelessDeployed = 0;
    // Update is called once per frame
    void Update()
    {
        GameObject firstHomeless = GameObject.FindGameObjectWithTag("FirstHomeless");
        GameObject secondHomeless = GameObject.FindGameObjectWithTag("SecondHomeless");
        GameObject thirdHomeless = GameObject.FindGameObjectWithTag("AussieHomeless");
        hat = FindObjectOfType<collectibleScript>();
        if(hat.hats > homelessDeployed)
        {
            homelessDeployed++;
            if(homelessDeployed == 1)
            {
                firstHomeless.transform.position = new Vector3(45f, 20f, 10f);
            }
            else if(homelessDeployed == 2)
            {
                secondHomeless.transform.position = new Vector3(45f, 20f, 0f);
            }
            else if(homelessDeployed == 3)
            {
                thirdHomeless.transform.position = new Vector3(45f, 20f, -10f);
            }
        }

    }
}
