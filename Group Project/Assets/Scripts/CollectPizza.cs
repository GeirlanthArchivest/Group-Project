using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPizza : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        score.theScore += 50;
        Destroy(gameObject);
    }
}
