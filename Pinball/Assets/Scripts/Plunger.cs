using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunger : MonoBehaviour {

    Animator anim;

    AudioSource sonido;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
        sonido = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("New Trigger");
            sonido.Play();
        }
    }
}
