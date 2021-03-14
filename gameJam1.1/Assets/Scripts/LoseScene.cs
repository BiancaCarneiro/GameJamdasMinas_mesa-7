using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScene : MonoBehaviour
{
    PlayerController playerController;
    CheckHeight checkHeight;
    public float winHeight = 20f;
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        checkHeight = GameObject.Find("CheckHeight").GetComponent<CheckHeight>();
    }

    void Update()
    {
        if (playerController.gameOver)
        {
            SceneManager.LoadScene("Derrota");
        }

        if (checkHeight.bgHeight <= -winHeight)
        {
            SceneManager.LoadScene("Vitoria");
        }
    }
}
