using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    



    public GameObject OpenedDoor;



    void Start()
    {
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.F))
            {
                this.gameObject.SetActive(false);
                
                OpenedDoor.SetActive(true);
            }
        }
    }
}