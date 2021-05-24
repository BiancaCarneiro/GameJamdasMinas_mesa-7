using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    public float speed = 6f;
    private float movementLimits;
    public HealthSystem healthSystem;
    public bool gameOver;
    private Rigidbody2D rb2d;

    void Start()
    {
        healthSystem = new HealthSystem(3);
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        rb2d.gravityScale = 2f;
    }

    void Update()
    {
        movementLimits = GetBounds().x - GetPlayerWidth();
        
        MovePlayer();
        LimitPlayerMovement();
        CheckDeathCondition();
    }

    private void CheckDeathCondition()
    {
        if (transform.position.y < -GetBounds().y || healthSystem.GetHealth() == 0)
        {
            gameOver = true;
        }
    }

    #region Player Movement
    private void MovePlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2(1, 0) * (horizontalInput * speed * Time.deltaTime));
    }

    private void LimitPlayerMovement()
    {
        if (transform.position.x < -movementLimits)
        {
            transform.position = new Vector2(-movementLimits, transform.position.y);
        }

        if (transform.position.x > movementLimits)
        {
            transform.position = new Vector2(movementLimits, transform.position.y);
        }
    }
    #endregion
    private Vector3 GetBounds()
    {
        return Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    }
    private float GetPlayerWidth()
    {
        return transform.GetComponent<Collider2D>().bounds.size.x / 2;
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
