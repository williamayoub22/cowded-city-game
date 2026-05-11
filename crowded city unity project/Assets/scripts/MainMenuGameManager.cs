using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuGameManager : MonoBehaviour
{

    public void episode1()
    {
        SceneManager.LoadScene(2);
    }

    public void episode2()
    {
        SceneManager.LoadScene(3);
    }
    public void episode3()
    {
        SceneManager.LoadScene(4);
    }
    public void episode4()
    {
        SceneManager.LoadScene(5);
    }
    public void episode5()
    {
        SceneManager.LoadScene(6);
    }
    public void episode6()
    {
        SceneManager.LoadScene(7);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}

