using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    private readonly float speed = 1;
    private readonly float parallaxSpeed = 0.4f;
    private float counterT = 4; 
    public static bool desce = true; //saber se o fundo vai descer 

    void Update()
    {
        if (counterT > 0) counterT -= Time.deltaTime;
        if (counterT <= 0 && desce)
        {
            // Faz o fundo mover para cima
            GameObject.Find("Background").transform.Translate(Vector2.down * (speed * Time.deltaTime));
            GameObject.Find("Parallax").transform.Translate(Vector2.down * (parallaxSpeed * Time.deltaTime));
        }
    }
}
