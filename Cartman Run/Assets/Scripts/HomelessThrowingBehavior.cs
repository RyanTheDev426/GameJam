using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomelessThrowingBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    RockBehavior[] rockArray;
    int currentRockIndex = 0;
    float timer = 10f;

    void Start()
    {
        rockArray = FindObjectsOfType<RockBehavior>();
    }
    void Update()
    {
        timer--;
        if (gameObject.CompareTag("FirstHomeless") && FindObjectOfType<HomelessScript>().homelessDeployed >= 1)
        {
            if (timer <= 0f)
            {
                timer = Random.Range(500f, 1500f);
                if(currentRockIndex < rockArray.Length)
                {
                    RockBehavior nextRock = rockArray[currentRockIndex];
                    nextRock.rockThrown = true;
                    nextRock.transform.position = transform.position;
                    currentRockIndex++;
                }
                else
                {
                    RockBehavior nextRock = rockArray[0];
                    nextRock.rockThrown = true;
                    nextRock.transform.position = transform.position;
                    currentRockIndex = 1;
                }
            }

        }
        else if (gameObject.CompareTag("SecondHomeless") && FindObjectOfType<HomelessScript>().homelessDeployed >= 2)
        {
            if (timer <= 0f)
            {
                timer = Random.Range(500f, 1500f);
                if (currentRockIndex < rockArray.Length)
                {
                    RockBehavior nextRock = rockArray[currentRockIndex];
                    nextRock.rockThrown = true;
                    nextRock.transform.position = transform.position;
                    currentRockIndex++;
                }
                else
                {
                    RockBehavior nextRock = rockArray[0];
                    nextRock.rockThrown = true;
                    nextRock.transform.position = transform.position;
                    currentRockIndex = 1;
                }
            }
        }
        else if (gameObject.CompareTag("AussieHomeless") && FindObjectOfType<HomelessScript>().homelessDeployed >= 1)
        {

        }
    }
}
