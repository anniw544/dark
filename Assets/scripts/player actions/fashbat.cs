using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fashbat : MonoBehaviour
{
    public int battery = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if(battery > 0)
        {
            battery -= 1;
        }
    }
    
}

    