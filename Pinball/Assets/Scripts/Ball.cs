using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private Rigidbody rbody;
    public float x = 43;
    private float y = 1;
    public float z = 6.93F;

    private GameController gameController;

    // Use this for initialization
    void Start () {
        rbody = GetComponent<Rigidbody>();

        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }
	
	// Update is called once per frame
	void Update () {
        		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Abajo")
        {
            print("Perdiste");
            gameController.restarVida();
            transform.position = new Vector3(x, y, z);
        } 
    }

}
