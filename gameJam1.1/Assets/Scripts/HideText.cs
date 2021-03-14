using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideText : MonoBehaviour
{
    GameHandler gameHandler;

    void Start()
    {
        gameHandler = GameObject.Find("GameHandler").GetComponent<GameHandler>();
    }

    void Update()
    {
        if (!gameHandler.paused)
        {
            GameObject.Find("Text").SetActive(false);
        }
    }
}
