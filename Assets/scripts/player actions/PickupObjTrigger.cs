using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjTrigger : MonoBehaviour
{
    


// object 1 that appeares
    public GameObject ColectedObj;
// object 2 that appeares
    public GameObject TriggerObj;
//object that dissapeares
    public GameObject DeleatedObj;
//ui that dissapeares
    public GameObject UI;
//box for item toggle
    public GameObject box;



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
                // hides and deactivates the interaced object
                this.gameObject.SetActive(false);
                // deaactivates the DeleatedObj object
                DeleatedObj.SetActive(false);
                //activates object 1
                ColectedObj.SetActive(true);
                //activates object 2
                TriggerObj.SetActive(true);
                // deaactivates the Ui
                UI.SetActive(false);
                // activeate the box
                box.SetActive(true);

                
            }
        }
    }
}
