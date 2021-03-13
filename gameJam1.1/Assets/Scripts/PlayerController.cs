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
    public float force = 12f;
    Rigidbody2D rb2d;
    private StartScript startScript;

    void Start()
    {
        // Inicia o sistema de vida;
        healthSystem = new HealthSystem(3);

        // Tamanho do Player
        playerWidth = transform.GetComponent<Collider2D>().bounds.size.x / 2;
        rb2d = gameObject.GetComponent<Rigidbody2D>();
<<<<<<< HEAD

        startScript = GameObject.Find("GameHandler").GetComponent<StartScript>();
=======
        startScript = GameObject.Find("GameHandler").GetComponent<StartScript>();

>>>>>>> 189771943d1007e0fc142895cd22b046eec9ac1c
        rb2d.gravityScale = 2f;
    }


    void Update()
    {
        // Vari�veis
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
        if (transform.position.y < -5.5 || healthSystem.GetHealth() == 0)
        {
            gameOver = true;
<<<<<<< HEAD
            Debug.Log(gameOver);
            //startScript.started = true;
        } 
=======
        }

        if (startScript.canStart && !startScript.started)
        {
            rb2d.AddForce(Vector2.up * force, ForceMode2D.Impulse);
            startScript.started = true;
        }
>>>>>>> 189771943d1007e0fc142895cd22b046eec9ac1c
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Se o Player � atingido por um proj�til, ele perde uma vida
        if (collision.gameObject.CompareTag("Projectile"))
        {
            healthSystem.Damage(1);
            Destroy(collision.gameObject);
        }
    }
<<<<<<< HEAD
=======

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform") && startScript.canStart)
        {
            rb2d.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }
>>>>>>> 189771943d1007e0fc142895cd22b046eec9ac1c
}
