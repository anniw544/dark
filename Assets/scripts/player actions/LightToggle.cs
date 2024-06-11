using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightToggle : MonoBehaviour
{


    public GameObject Light;
    int light_on = 0;
    public int battery = 100;
    public int bat_refil = 0;
    public GameObject LB1;
    public GameObject LB2;
    public GameObject LB3;
    
    
    void Start () 
    {
        light_on = 0;
        //int bat_refil = 1;
    }



 // shacborgaosisy
    private void OnTriggerStay(Collider other)
    {
    
        if (Input.GetKey(KeyCode.E) && other.tag == "lart")
        {
            Debug.Log(bat_refil);
            bat_refil += 1;
            other.gameObject.SetActive(false);
            Debug.Log(bat_refil);
        
        }
                
    }
    
    // private void OnTriggerEnter(Collider other)
    // {
    //     if (Input.GetKey(KeyCode.E) && other.tag == "lart")
    //     {
            
    //         bat_refil += 1;
        
        
    //     }
    // }

    void Update()
    
    {

        if (Input.GetKey(KeyCode.Mouse0) && light_on == 0 && battery > 0)
        {
            Light.SetActive(true);
            StartCoroutine(LightOn());
             
        }

        if (Input.GetKey(KeyCode.Mouse0) && light_on == 1)
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
 // shoborgus
        if (Input.GetKeyDown(KeyCode.R) && bat_refil > 0)
        {
            Debug.Log("refill start");
            battery = 2000;
            bat_refil -= 1;
            Debug.Log("refill end");
        }

        if (battery > 1332)
        {
            LB1.SetActive(true);
            LB2.SetActive(false);
            LB3.SetActive(false);
        }
        else if (battery > 666)
        {
            LB1.SetActive(false);
            LB2.SetActive(true);
            LB3.SetActive(false);
        }
        else if (battery < 666)
        {
            LB1.SetActive(false);
            LB2.SetActive(false);
            LB3.SetActive(true);
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