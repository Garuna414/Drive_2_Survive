using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoBack : MonoBehaviour
{
    public PauseMenu script;

    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        script.pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        script.GameIsPaused = false;

    }
    public void BackToMenu2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        script.pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        script.GameIsPaused = false;

    }
    public void BackToMenu3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        script.pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        script.GameIsPaused = false;

    }
    public void BackToMenu4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
        script.pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        script.GameIsPaused = false;

    }
    public void BackToMenu5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
        script.pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        script.GameIsPaused = false;

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
