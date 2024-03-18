using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BHand : MonoBehaviour
{
    
    private Animation anim;

 void Start()
    {
        
        Debug.Log("e");
    }


  void OnTriggerEnter(Collider other)
    {
        Debug.Log("meep");
        if(other.gameObject.tag == "Flash")
        {  
            anim = other.GetComponent<Animation>();
            Debug.Log("Death");
            anim.Play("kill");
        }
        else
        {
            Debug.Log(other.tag);
        }
    }
}
