using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverData : MonoBehaviour {

    public GameObject gameOverDatapepe;

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        gameOverDatapepe.SetActive(false);
    }
}
