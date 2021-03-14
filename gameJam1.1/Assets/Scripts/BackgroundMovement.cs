using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    // Variaveis
    public float speed = 0.5f;

    void Update()
    {
        // Faz o fundo mover para cima
        transform.Translate(Vector2.down * speed * Time.deltaTime);

    }
}
