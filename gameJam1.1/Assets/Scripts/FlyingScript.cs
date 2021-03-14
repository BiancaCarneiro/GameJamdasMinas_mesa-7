using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingScript : MonoBehaviour
{
    // Variaveis
    public float speed;
    float counterT = 1; 


    void Update()
    {
        if (counterT > 0) counterT -= Time.deltaTime;
        if (counterT <= 0){//espera 5 segundos para comecar o movimento
            // Voa o objeto voar no inicio. Se quiser que pause junto com o resto, Time.deltaTime
            transform.Translate(Vector2.up * Time.unscaledDeltaTime * speed);
        }
    }
}
