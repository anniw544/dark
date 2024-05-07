using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightfix : MonoBehaviour
{


    public GameObject Flight;
    public GameObject box;
    public GameObject current;


    void Start()
    {
    }

    void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
            Debug.Log("click");
                this.gameObject.SetActive(false);
                
                Flight.SetActive(true);
                box.SetActive(true);
                current.SetActive(false);

               
            }
        }
    
}

