using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject PlayButton2;

    /*void Update()
    {
        LevelUnlock();
    }*/

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
        
    }
    public void Level2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Time.timeScale = 1f;

    }
    public void Level3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        Time.timeScale = 1f;

    }
    public void Level4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        Time.timeScale = 1f;

    }
    public void Level5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
        Time.timeScale = 1f;

    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
    /*
    public void LevelUnlock()
    {
        if (PlayerPrefs.GetInt("Finish1") == 0)
        {
            PlayButton2.SetActive(true);
        }
    }*/
    /*
    public void LevelUnlock()
    {
        if (Finish.fin1 == true)
        {
            PlayButton2.SetActive(true);
        }
    }*/
}
