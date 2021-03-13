using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    // Vari�veis
    public float speed = 0.5f;
    private PlayerController playerController;

    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Faz o fundo mover para cima;
    void Update()
    {
        if (!playerController.gameOver)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}
