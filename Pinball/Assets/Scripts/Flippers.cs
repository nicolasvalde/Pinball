using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flippers : MonoBehaviour
{

    Animator anim;

    AudioSource aus;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        aus = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetTrigger("LeftTrigger");
            aus.Play();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetTrigger("RightTrigger");
            aus.Play();
        }
        
    }
}
