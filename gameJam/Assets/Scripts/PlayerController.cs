using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variaveis
    private float horizontalInput;
    public float speed = 6f;
    private Vector3 bounds;
    private float playerWidth;
    private float movementLimits;
    public HealthSystem healthSystem;
    public bool gameOver = false;

    void Start()
    {
        healthSystem = new HealthSystem(3);

        // Tamanho do Player
        playerWidth = transform.GetComponent<Collider2D>().bounds.size.x / 2;
    }


    void Update()
    {
        // Variáveis
        bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        movementLimits = bounds.x - playerWidth;

        // Movimento do Player
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2(1, 0) * horizontalInput * speed * Time.deltaTime);

        // Limita o movimento do Player para qualquer Aspect Ratio
        if (transform.position.x < -movementLimits)
        {
            transform.position = new Vector2(-movementLimits, transform.position.y);
        }
        if (transform.position.x > movementLimits)
        {
            transform.position = new Vector2(movementLimits, transform.position.y);
        }

        // Se o Player perde todas as vidas, o jogo acaba
        if (healthSystem.GetHealth() == 0)
        {
            gameOver = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Se o Player é atingido por um projétil, ele perde uma vida
        if (collision.gameObject.CompareTag("Projectile"))
        {
            healthSystem.Damage(1);
            Destroy(collision.gameObject);
        }
    }
}
