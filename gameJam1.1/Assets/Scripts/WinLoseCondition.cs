using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class WinLoseCondition : MonoBehaviour
{
    PlayerController playerController;
    CheckHeight checkHeight;
    private int winCondition = 10;
    public float timer;
    private int counter;
    public TMP_Text timerText;

    void Start()
    {
        counter = winCondition;
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        checkHeight = GameObject.Find("CheckHeight").GetComponent<CheckHeight>();
    }

    void Update()
    {
        if (playerController.gameOver)
        {
            SceneManager.LoadScene("Derrota");
        }

        if (checkHeight.bgHeight <= -checkHeight.enemyHeight)
        {
            Timer();
        }
    }

    void Timer()
    {
        timer += Time.deltaTime;
        while (timer >= 1)
        {
            counter--;
            timer = 0;
        }

        if (counter == 0)
        {
            SceneManager.LoadScene("Vitoria");
        }

        timerText.SetText(counter.ToString());
    }
}
