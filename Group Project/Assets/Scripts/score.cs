using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public GameObject ScoreText;
    public int theScore;
    
    void OnTriggerEnter(Collider other)
    {
        theScore += 50;
        ScoreText.GetComponentInChildren<Text>().text = "SCORE: " + theScore;
        Destroy(gameObject);
    }
}
