using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScene : MonoBehaviour
{
    PlayerController playerController;
    CheckHeight checkHeight;
    private float winCondition = 35f;
    public float counter;
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

        if (checkHeight.bgHeight <= -54)
        {
            counter += Time.deltaTime * 2;
            if (counter >= winCondition)
            {
                SceneManager.LoadScene("Vitoria");
            }
        }
    }
}
