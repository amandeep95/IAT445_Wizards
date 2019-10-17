using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFire : MonoBehaviour
{
    
    public GameObject fireball;
    public Transform wand; //roataion
    public Transform shootpoint; //position
    public float shootRate = 0f;
    public float shootForce = 0f;
    private float shootRateTimeStamp = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || OVRInput.Get(OVRInput.RawButton.X))
        {
            if (Time.time > shootRateTimeStamp) {
                GameObject go = (GameObject) Instantiate(fireball, shootpoint.position, wand.rotation);
                go.GetComponent<Rigidbody>().AddForce(shootpoint.forward * shootForce);
                shootRateTimeStamp = Time.time + shootRate;
            }
        }

    }

    
}
