using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewEndGame2 : MonoBehaviour
{
    public GameObject GameOverMenuUI;
    private float time = 0.0f;
    public Text timer;
    public Text highscore;

    void Start()
    {
        StartTimer();
        if (PlayerPrefs.HasKey("Hscore2") == true)
        {
            highscore.text = "Best: " + PlayerPrefs.GetFloat("Hscore2").ToString("f1");
        }
        else
        {
            highscore.text = "No Best";
        }
        
    }

    public void StartTimer()
    {
        time = 0.0f;
        InvokeRepeating("IncrimentTime", 0.1f, 0.1f);
    }

    public void StopTimer()
    {
        CancelInvoke();
        if (PlayerPrefs.GetFloat("Hscore2") > time)
        {
            PlayerPrefs.SetFloat("Hscore2", time);
        }
    }

    void IncrimentTime()
    {
        time += 0.1f;
        timer.text = "Time: " + time.ToString("f1");
    }

    void OnTriggerEnter2D()
    {
        GameOverMenuUI.SetActive(true);                
        Time.timeScale = 0f;
    }

    public void setHighScore()
    {
        if (PlayerPrefs.HasKey("Hscore2") == true)
        {
            StopTimer();
        }
        else
        {
            PlayerPrefs.SetFloat("Hscore2", time);
        }
        
        //PlayerPrefs.Save();
        highscore.text = "Best: " + PlayerPrefs.GetFloat("Hscore2").ToString("f1");
    }
}