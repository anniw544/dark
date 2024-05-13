using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class specticals : MonoBehaviour
{


    public GameObject Light;
    int light_on = 1;
    public int battery = 100;
    
    void Start () 
    {
        light_on = 0;
       
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1) && light_on == 0 && battery > 0)
        {
            Light.SetActive(true);
            StartCoroutine(LightOn());
             
        }

        if (Input.GetKey(KeyCode.Mouse1) && light_on == 1)
        {
            Light.SetActive(false);
            StartCoroutine(LightOff());
             
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