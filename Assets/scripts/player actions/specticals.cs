using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class specticals : MonoBehaviour
{


    public GameObject Light;
    int light_on = 1;
    public int battery = 100;
    public GameObject textHide;
   
    
    void Start () 
    {
        light_on = 0;
        textHide.SetActive(false);
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1) && light_on == 0 && battery > 0)
        {
            Light.SetActive(true);
            StartCoroutine(LightOn());
            textHide.SetActive(true);
            
             
        }

        if (Input.GetKey(KeyCode.Mouse1) && light_on == 1)
        {
            Light.SetActive(false);
            StartCoroutine(LightOff());
            textHide.SetActive(false);
           
        }
// shabingus
        if (battery > 0 && light_on == 1)
        {
            battery -= 1;
        }

        if (battery == 0)
        {
            Light.SetActive(false);
            light_on = 0;
            textHide.SetActive(false);
            
        }
    }

        private IEnumerator LightOn()
    { 
            yield return new WaitForSeconds(1);
            light_on = 1;    
    }

    private IEnumerator LightOff()
    { 
            yield return new WaitForSeconds(1);
            light_on = 0;
    }
}