using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracerFollow : MonoBehaviour
{

    public GameObject plane;
    Animator anim;
    public string animationName;

    private LineRenderer line;
    private GameObject wand;

    private float startTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        //anim = 
        //anim.Stop(animationName, 0, 0.25f);
        //anim.StopPlayback();
        //anim.StartPlayback();

        //anim.GetCurrentAnimatorStateInfo(0);



        line = gameObject.AddComponent<LineRenderer>();
        line.positionCount = 2;
        line.startWidth = 0.008f;
        line.endWidth = line.startWidth;
        line.startColor = Color.white;
        line.endColor = Color.white;
        line.material = new Material(Shader.Find("Unlit/Texture"));

        //player = GameObject.Find("");
        wand = GameObject.FindGameObjectWithTag("Wand");
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(0, this.transform.position);
        line.SetPosition(1, wand.transform.position);


        //show current speed
        //float sped =  anim.GetCurrentAnimatorStateInfo(0).speed;
        ////print(sped);
    }

    void OnTriggerEnter(Collider other)
    {
        //anim.Play("");
        if (other.gameObject.tag == "Wand")
        {
            print("Wand Connected");
            //anim.Play(animationName);
            //anim.StartPlayback();
            anim.StopPlayback();
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Wand")
        {
            //print("STAY!");
            //start counter
            startTime += Time.deltaTime;
            //Debug.Log(startTime);

            float sped = anim.GetCurrentAnimatorStateInfo(0).speed;
            print(sped);

            if (startTime < 10)
            {
                anim.speed = 1f;
                sped = anim.GetCurrentAnimatorStateInfo(0).speed;
                print(sped);
            } else if (startTime < 15)
            {
                anim.speed = 2f;
                sped = anim.GetCurrentAnimatorStateInfo(0).speed;
                print(sped);
            } else if (startTime < 20)
            {
                anim.speed = 3f;
                sped = anim.GetCurrentAnimatorStateInfo(0).speed;
                print(sped);
            } else if (startTime < 25)
            {
                anim.StartPlayback();
                print("End Animation");
                Destroy(plane);
            }
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Wand")
        {
            print("Wand Exit");
            //anim.StopPlayback();
            anim.StartPlayback();

        }
    }
}
