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
    public GameObject endText;
    public GameObject endText1;

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
        if (score.theScore >= 750)
        {
            endText.SetActive(true);
        }
        else
        {
            endText1.SetActive(true);
        }

    }
    public void Cont()
    {
        endMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        if (score.theScore >= 750)
        {
            endBars.SetActive(false);
            endRoom.SetActive(true);
        }
        else
        {

        }
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}