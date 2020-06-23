using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public GameObject restartButton;
    public GameObject mmButton;

    private void Start()
    {
        restartButton.SetActive(false);
        mmButton.SetActive(false);
    }

    public void ActivateButtons()
    {
        restartButton.SetActive(true);
        mmButton.SetActive(true);
    }

    public void GoToMM()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
