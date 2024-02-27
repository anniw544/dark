using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prompt : MonoBehaviour
{
    



    public GameObject Prompt;



    void Start()
    {
        Prompt.SetActive(false);
    }



      void OnTriggerExit(Collider other)

    {
        if(other.gameObject.tag == "CollectableItem")
        {
            Debug.Log("dissapear");
                Prompt.SetActive(false);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "CollectableItem")
        {
            Debug.Log("appear");
                Prompt.SetActive(true);

        }
    }
}

