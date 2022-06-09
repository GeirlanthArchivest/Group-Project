using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turtleUI : MonoBehaviour
{
    public GameObject Turtle;
    public static bool GameIsPaused = false;
    public GameObject Instructions;

    // Start is called before the first frame update
    void Start()
    {
        Pause();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Pause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Cont()
    {
        Turtle.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Instructions.SetActive(true);
    }
}
