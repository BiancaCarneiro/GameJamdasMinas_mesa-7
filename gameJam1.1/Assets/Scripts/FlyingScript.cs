using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingScript : MonoBehaviour
{
    // Variaveis
    public float speed;

    // Faz o objeto voar
    void Update()
    {
        // Voa no inicio. Se quiser que pause junto com o resto, Time.deltaTime
        transform.Translate(Vector2.up * Time.unscaledDeltaTime * speed);
    }
}
