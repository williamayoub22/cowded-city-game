using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class welcomeGameManager : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Options()
    {
        SceneManager.LoadScene(8);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}

