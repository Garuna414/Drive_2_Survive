using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject GameOverMenuUI;

    void OnTriggerEnter2D()
    {
        GameOverMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
