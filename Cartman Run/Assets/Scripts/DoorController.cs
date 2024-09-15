using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;
    private int hat_count = 0;
    public collectibleScript hat;


    private void OnTriggerEnter(Collider other)
    {
        hat = FindObjectOfType<collectibleScript>();
        hat_count = hat.hats;
        if (other.CompareTag("Player"))
        {
            if (openTrigger && hat_count >= 2)
            {
                myDoor.Play("Door Opening", 0, 0.0f);
                gameObject.SetActive(false);
            }
            else if (closeTrigger)
            {
                myDoor.Play("Door Closing", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}
