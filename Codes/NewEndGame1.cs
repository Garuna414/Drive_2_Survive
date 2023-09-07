using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewEndGame1 : MonoBehaviour
{
    //public GameObject GameOverMenuUI;
    private float time = 0.0f;
    public Text timer;
    public Text highscore;

    void Start()
    {
        StartTimer();
        if (PlayerPrefs.HasKey("Hscore1") == true)
        {
            highscore.text = "Best: " + PlayerPrefs.GetFloat("Hscore1").ToString("f1");
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
        if (PlayerPrefs.GetFloat("Hscore1") > time)
        {
            PlayerPrefs.SetFloat("Hscore1", time);
        }
    }

    void IncrimentTime()
    {
        time += 0.1f;
        timer.text = "Time: " + time.ToString("f1");
    }

    /*void OnTriggerEnter2D()
    {
        GameOverMenuUI.SetActive(true);                
        Time.timeScale = 0f;
    }*/

    public void setHighScore()
    {
        if (PlayerPrefs.HasKey("Hscore1") == true)
        {
            StopTimer();
        }
        else
        {
            PlayerPrefs.SetFloat("Hscore1", time);
        }
        
        //PlayerPrefs.Save();
        highscore.text = "Best: " + PlayerPrefs.GetFloat("Hscore1").ToString("f1");
    }
}