using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour {
    public float force = 100.0f;
    public float forceRadius = 1.0f;
    public bool encendido;
    public int puntos = 0;
    private GameController gameController;
    // Use this for initialization
    void Start () {
        //Se hace uso de la instancia del GameController ya existente, tanto en los bumpers como en la bola
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
        foreach (Collider col in Physics.OverlapSphere(transform.position, forceRadius))
        {
            if (col.GetComponent<Rigidbody>())
            {
                col.GetComponent<Rigidbody>().AddExplosionForce(force, transform.position, forceRadius);
            }
        }
        gameController.sumarPuntos(puntos);
    }
}
