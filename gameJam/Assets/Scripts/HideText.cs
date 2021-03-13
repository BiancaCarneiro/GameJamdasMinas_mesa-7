using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideText : MonoBehaviour
{
    StartScript startScript;

    void Start()
    {
        startScript = GameObject.Find("GameHandler").GetComponent<StartScript>();
    }

    void Update()
    {
        if (startScript.canStart == true)
        {
            GameObject.Find("Text").SetActive(false);
        }
    }
}
