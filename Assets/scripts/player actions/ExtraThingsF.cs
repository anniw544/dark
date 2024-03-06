using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraThingsF : MonoBehaviour
{


    public GameObject Appear1;
    public GameObject Appear2;
    public GameObject Dissapear1;


    void Start()
    {
        Appear1.SetActive(false);
        Appear2.SetActive(false);
        Dissapear1.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.F))
            {
                this.gameObject.SetActive(false);
                
                Appear1.SetActive(true);
                Appear2.SetActive(true);
                Dissapear1.SetActive(false);
            }
        }
    }
}