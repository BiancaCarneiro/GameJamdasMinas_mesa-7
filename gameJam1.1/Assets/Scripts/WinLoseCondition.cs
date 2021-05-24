using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class WinLoseCondition : MonoBehaviour
{
    private PlayerController playerController;
    private CheckHeight checkHeight;
    private readonly int winCondition = 15;
    private float tick;
    private int timer;
    [SerializeField] private TMP_Text timerText;

    void Start()
    {
        timer = winCondition;
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        checkHeight = GameObject.Find("CheckHeight").GetComponent<CheckHeight>();
    }

    void Update()
    {

        if (checkHeight.BgHeight <= -checkHeight.EnemyHeight)
        {
            Timer();
        }
        else
        {
            timerText.enabled = false;
        }
        
        CheckLoseCondition();
        CheckWinCondition();
    }

    private void CheckLoseCondition()
    {
        if (playerController.gameOver)
        {
            SceneManager.LoadScene("Derrota");
        }
    }

    private void CheckWinCondition()
    {
        if (timer == 0)
        {
            SceneManager.LoadScene("Vitoria");
        }
    }

    void Timer()
    {
        timerText.enabled = true;
        tick += Time.deltaTime;
        while (tick >= 1)
        {
            timer--;
            tick = 0;
        }
        timerText.SetText(timer.ToString());
    }
}
