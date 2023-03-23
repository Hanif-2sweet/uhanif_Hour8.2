using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightBulb : MonoBehaviour
{
    // Start is called before the first frame update

    Light lightComponent;
    void Start()
    {
        lightComponent = GetComponent<Light> ();

    }
    

    // Update is called once per frame
    void Update()
    {
        bool isKeyDown = Input.GetKeyDown (KeyCode.L);

        if(Input.GetKeyDown (KeyCode.L))
            lightComponent.enabled = !lightComponent.enabled;
        
     





    }
}
