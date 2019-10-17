﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLevitation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (Input.GetKey(KeyCode.Y) || OVRInput.Get(OVRInput.RawButton.Y))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                Debug.Log("Hit Somthing");
            }
            
        }
    }
}
