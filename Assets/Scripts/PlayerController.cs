using System;
using System.Threading;
using System.Collections.Specialized;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the car forward 
        transform.Translate(UnityEngine.Vector3.forward * Time.deltaTime * 20);
        
    
    }
}
