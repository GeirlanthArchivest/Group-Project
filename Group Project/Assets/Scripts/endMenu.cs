using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject endMenuUI;

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Player")
        {
            if (GameIsPaused)
            {
                Cont();
            }
            else
            {
                Pause();
            }
            Debug.Log("TEST");
        }
    }

    void Pause()
    {
        endMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Cont()
    {
        endMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}