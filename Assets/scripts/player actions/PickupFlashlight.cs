using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupFlashlight : MonoBehaviour
{
    


    public bool flashLightHave;
    public GameObject FlashLightOnPlayer;



    void Start()
    {
        FlashLightOnPlayer.SetActive(false);

        flashLightHave = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                flashLightHave = true;
                
                this.gameObject.SetActive(false);
                
                FlashLightOnPlayer.SetActive(true);
            }
        }
    }
}
