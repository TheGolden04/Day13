using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightExample : MonoBehaviour
{
    public Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        myLight.color = Color.red;
        myLight.intensity = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
