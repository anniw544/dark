using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjTrigger : MonoBehaviour
{
    



    public GameObject ColectedObj;
    public GameObject TriggerObj;
    public GameObject DeleatedObj;



    void Start()
    {
        ColectedObj.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);

                DeleatedObj.SetActive(false);
                
                ColectedObj.SetActive(true);

                TriggerObj.SetActive(true);
                
            }
        }
    }
}
