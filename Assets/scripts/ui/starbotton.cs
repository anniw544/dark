using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class starbotton : MonoBehaviour
{

//int jabingus = 1;
public Camera yep;


//     void Update()
//     {
//         if (jabingus == 1 && Input.GetKeyDown(KeyCode.Space))
//         {
//             SceneManager.UnloadSceneAsync (sceneName: "test map");
//             SceneManager.LoadScene (sceneName: "Tutorial");

//             jabingus = 0;
//         }      
//     }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = yep.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if(hit.collider.tag == "storT")
                    {
                        SceneManager.UnloadSceneAsync (sceneName: "test map");
                        SceneManager.LoadScene (sceneName: "Tutorial");
                    }
                }
            }
        }
}
