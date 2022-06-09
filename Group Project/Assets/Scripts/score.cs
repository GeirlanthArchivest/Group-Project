using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public GameObject ScoreText;
    public static int theScore;
    
    void Update()
    {
        ScoreText.GetComponentInChildren<Text>().text = "SCORE: " + theScore;
    }
}
