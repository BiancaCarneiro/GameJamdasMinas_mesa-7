using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    // Variaveis
    public bool paused;
    PlayerController playerController;

    // O tempo nao passa no inicio
    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        paused = true;
        Time.timeScale = 0;
    }

    void Update()
    {
        // Aperte espaco para comecar
        if(Input.GetKeyDown(KeyCode.Space))
        {
            paused = false;
        }

        // Se o jogo comecar, despausa o jogo
        if (!paused)
        {
            Time.timeScale = 1;
        } else
        {
            Time.timeScale = 0;
        }


        if (playerController.gameOver)
        {
            paused = true;
        }
    }
}
