using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BHand : MonoBehaviour
{
    
    private Animation anim;

 void Start()
    {
         anim = gameObject.GetComponent<Animation>();
        
    }


  private void OnTriggerStay(Collider other)
    {
    if(other.gameObject.tag == "Flash")
        {  
            Debug.Log("Death");
            anim.Play("kill");
        }
    else
    {
            anim.Play("BHandLmbIdle");
    }
    
    }
}
