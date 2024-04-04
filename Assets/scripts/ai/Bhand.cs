using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BHand : MonoBehaviour
{
    
    private Animation anim;




  void OnTriggerEnter(Collider other)
    {
            //Debug.Log("touvhy");
        if(other.gameObject.tag == "spoopy")
        {  
            //Debug.Log("Death");
            StartCoroutine(BhDeath(other.gameObject));
        }

    }

    IEnumerator BhDeath(GameObject other)
    {
        yield return new WaitForSeconds(3.0f);
        Destroy(other);
    }
}
