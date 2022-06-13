using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject endMenuUI;
    public GameObject endBars;
    public GameObject endRoom;
    void OnTriggerEnter()
    {
        Pause();
    }

    void Pause()
    {
        endMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        GetComponent<Collider>().enabled = false;

    }
    public void Cont()
    {
        endMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        endBars.SetActive(false);
        endRoom.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}