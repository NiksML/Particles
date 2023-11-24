using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    
    public KeyCode[] controllers;
    public float speed;
    
    // 0 - up , 1 - left , 2 - down , 3 - right

    private void Start()
    {
        
    }
    void Update()
    {
        //ParticleRotation();
        Movement();
    }

    private void Movement()
    {
        if (Input.GetKey(controllers[0]))
        {
            transform.Translate(0, 0, speed * 1 * Time.deltaTime);
            
        }
        if (Input.GetKey(controllers[1]))
        {
            transform.Translate(speed * -1 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(controllers[2]))
        {
            transform.Translate(0, 0, speed * -1 * Time.deltaTime);
        }
        if (Input.GetKey(controllers[3]))
        {
            transform.Translate(speed * 1 * Time.deltaTime, 0, 0);
        } 
    }

    
}
