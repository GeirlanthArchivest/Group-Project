using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instructions : MonoBehaviour
{
    public GameObject TheInstructions;
    public int CloseInstruction;

    // Update is called once per frame
    void Update()
    {
        if (CloseInstruction == 1)
        {
            if (TheInstructions.transform.localScale.y <= 0.0f)
            {
                CloseInstruction = 0;
                TheInstructions.SetActive(false);
            }
            else
            {
                TheInstructions.transform.localScale -= new Vector3(0.0f, 0.01f, 0.0f);
            }
        }
    }

    void OnTriggerEnter()
    {
        StartCoroutine(finishInstructions());
    }

    IEnumerator finishInstructions()
    {
        TheInstructions.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        CloseInstruction = 1;
    }
}
