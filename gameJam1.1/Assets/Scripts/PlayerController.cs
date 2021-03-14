using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variaveis
    private float horizontalInput;
    public float speed = 6f;
    private Vector3 bounds;    
    private float aux;
    private float playerWidth;
    private float movementLimits;
    public HealthSystem healthSystem;
    public bool gameOver = false;
    public float force = 40f;
    Rigidbody2D rb2d;

    void Start()
    {
        // Inicia o sistema de vida;
        healthSystem = new HealthSystem(3);

        // Tamanho do Player
        playerWidth = transform.GetComponent<Collider2D>().bounds.size.x / 2;
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        aux = transform.position.y;
        rb2d.gravityScale = 2f; 
    }


    void Update()
    {
        // Variaveis
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
        if (transform.position.y < -bounds.y || healthSystem.GetHealth() == 0)
        {
            gameOver = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Se o Player for atingido por um projetil, ele perde uma vida
        if (collision.gameObject.CompareTag("Projectile"))
        {
            healthSystem.Damage(1);
            Destroy(collision.gameObject);
        }
    }
}
