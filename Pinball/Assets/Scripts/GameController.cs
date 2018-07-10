using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text textoPuntaje;
    public Text textoVidas;

    public GameObject gameOverData;
    public Text textoPuntajeGameOver;

    private int puntos;
    private int vidas;

    // Use this for initialization
    void Start () {
        puntos = 0;
        vidas = 3;
        actualizarPuntaje();
        actualizarVidas();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void sumarPuntos(int puntosNuevos)
    {
        puntos += puntosNuevos;
        actualizarPuntaje();
    }

    public void restarVida()
    {
        vidas--;
        actualizarVidas();

        if (vidas == 0)
        {
            gameOver();
        }
        
    }

    void actualizarPuntaje()
    {
        textoPuntaje.text = puntos + " puntos";
    }

    void actualizarVidas()
    {
        textoVidas.text = vidas + " vidas";
    }

    void gameOver()
    {
        Debug.Log("PERDIO");
        //HACER ALGO ACA
        textoPuntaje.text = puntos + " puntos";
        gameOverData.SetActive(true);
    }
}
