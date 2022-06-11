using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPizza : MonoBehaviour
{

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Player")
        {
            score.theScore += 50;
            Destroy(gameObject);
        }
    }
}
