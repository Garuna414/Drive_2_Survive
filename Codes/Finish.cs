using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public GameObject finishMenuUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            finishMenuUI.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("Cleared");
            if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                Debug.Log("You Completed ALL Levels");
            }
            else
            {
                if ((SceneManager.GetActiveScene().buildIndex + 1) > PlayerPrefs.GetInt("levelAt"))
                {
                    PlayerPrefs.SetInt("levelAt", SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
        }
    }
}
