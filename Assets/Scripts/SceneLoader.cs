using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void SplashScene()
    {
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentSceneIndex == 0)
        {
            StartCoroutine(SplashScreenTime());
            LoadNextScene();
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadNextScene()
    {
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MathHotPotatoe()
    {
        SceneManager.LoadScene("Math Hot Potatoe");
    }

    IEnumerator SplashScreenTime()
    {
        yield return new WaitForSeconds(3f);
    }
}
