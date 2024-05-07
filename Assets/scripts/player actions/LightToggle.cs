using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightToggle : MonoBehaviour
{


    private float flashOn;
    // 0 = on  1 = off
    public GameObject Flashreal;
    public GameObject Flashfake;
    bool flashLightHave;
    public GameObject flashOnTable;


    void Start () 
    {
        flashOn = 0;
       
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            flashLightHave = flashOnTable.GetComponent<PickupFlashlight>().flashLightHave;
            
            if (flashLightHave == true) 
            {     
                if(flashOn == 0)
                {
                    Flashreal.SetActive(false);
                    Flashfake.SetActive(true);
                    flashOn = 1;
                }
            
                else
                {
                    Flashreal.SetActive(false);
                    Flashfake.SetActive(true);
                    flashOn = 0;
                }

            }  
        }
    }
}