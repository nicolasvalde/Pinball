using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour {
    public float force = 100.0f;
    public float forceRadius = 1.0f;
    public int puntos = 0;
    //Se toma el renderer del objeto para trabajar sobre el material e iluminación
    private MeshRenderer renderer;
    private GameController gameController;
    // Use this for initialization
    void Start () {

        renderer = GetComponent<MeshRenderer>();

        renderer.material.globalIlluminationFlags = MaterialGlobalIlluminationFlags.RealtimeEmissive;

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
                encender();
            }
        }
        gameController.sumarPuntos(puntos);
    }

    private void encender()
    {
        renderer.material.EnableKeyword("_EMISSION");
        renderer.UpdateGIMaterials();
        //La espera se tiene que hacer en una co-rutina de tipo IEnumerator para que funcione
        StartCoroutine(Pausa());  
    }

    IEnumerator Pausa()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        renderer.material.DisableKeyword("_EMISSION");
        renderer.UpdateGIMaterials();
    }

}
