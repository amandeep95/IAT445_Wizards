﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{

    //public float power;
    public float expiryTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.GetComponent<Rigidbody>().AddForce(-transform.forward * power);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision != null)
        {
            Destroy(gameObject, expiryTime);
            print("Touching somthing");
        }
    }
}
