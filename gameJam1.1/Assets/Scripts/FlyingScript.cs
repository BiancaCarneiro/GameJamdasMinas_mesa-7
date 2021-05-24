using UnityEngine;

public class FlyingScript : MonoBehaviour
{
    private float speed = 2f;
    float counterT = 0.5f;

    void Update()
    {
        if (counterT > 0) counterT -= Time.deltaTime;
        if (counterT <= 0){ //espera 5 segundos para comecar o movimento
            // Faz o objeto voar no inicio. Se quiser que pause junto com o resto, Time.deltaTime
            transform.Translate(Vector2.up * (Time.unscaledDeltaTime * speed));
        }
    }
}
