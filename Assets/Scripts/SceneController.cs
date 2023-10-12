using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void StartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void AccountLoginRegis()
    {
        SceneManager.LoadScene("AccountLoginRegis");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ARMenu()
    {
        SceneManager.LoadScene("ARMenu");
    }

    public void MagnitudeScene()
    {
        SceneManager.LoadScene("MagnitudeScene");
    }

    public void FirstMagnitudeLvl()
    {
        SceneManager.LoadScene("FirstMagnitudeLvl");
    }

    public void SecondMagnitudeLvl()
    {
        SceneManager.LoadScene("SecondMagnitudeLvl");
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
