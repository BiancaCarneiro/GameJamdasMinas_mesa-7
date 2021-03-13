using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    // Variáveis
    public float speed = 0.5f;
    private PlayerController playerController;
    private StartScript startScript;

    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        startScript = GameObject.Find("GameHandler").GetComponent<StartScript>();
    }

    // Faz o fundo mover para cima;
    void Update()
    {
        if (!playerController.gameOver && startScript.canStart)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}
