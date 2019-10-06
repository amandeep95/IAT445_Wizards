using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracerPlane : MonoBehaviour
{
    
    
    public bool playerIn = false;
    public GameObject shape;

    // Start is called before the first frame update
    void Start()
    {
        shape.GetComponent<TracerFollow>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //print("hello");
    }

    void OnTriggerEnter(Collider other)
    {
        //print("Object Entered");
        if (other.gameObject.tag == "Player")
        {
            print("Player is Inbounds");
            playerIn = true;
            shape.GetComponent<TracerFollow>().enabled = true;
            //shape.GetComponent<LineRenderer>().enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("Player Left");
            playerIn = false;
            shape.GetComponent<TracerFollow>().enabled = false;
            //shape.GetComponent<LineRenderer>().enabled = true;
        }
    }
}
