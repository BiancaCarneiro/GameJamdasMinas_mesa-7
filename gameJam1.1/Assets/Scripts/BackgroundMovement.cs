using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    // Variaveis
    public float speed = 0.5f;
    float counterT = 4; 

    void Update()
    {
        if (counterT > 0) counterT -= Time.deltaTime;
        if (counterT <= 0){
            // Faz o fundo mover para cima
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}
