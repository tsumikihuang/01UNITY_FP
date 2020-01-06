using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    static public ChangeScene instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void GoToGame()
    {
        SceneManager.LoadScene("Jasper");
    }

    public void GoToGameOver()
    {
        SceneManager.LoadScene("gameOver");
    }
}
