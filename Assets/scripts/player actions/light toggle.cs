using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighttoggle : MonoBehaviour


    public GameObject FlashLightOnPlayer;
{

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKey(mousebutton(0)))
            {
                if (this.gameObject.SetActive=(false))
                {
                    this.gameObject.SetActive(false);
                    
                    FlashLightOnPlayer.SetActive(true);
                }

            }
        }
    }
}

