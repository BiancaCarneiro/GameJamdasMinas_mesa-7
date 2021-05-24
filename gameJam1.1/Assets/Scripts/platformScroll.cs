using UnityEngine;

public class platformScroll : MonoBehaviour
{
    public float jumpForce = 12f;
    float speed = 3f;
    public GameObject platform;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                platformSpawn.colisoes++;
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }
        }
    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,
            new Vector2(transform.position.x, transform.position.y - speed),
            speed * Time.deltaTime);
        
        if (platform.transform.position.y < -6)
        {
            Destroy(platform);
        }
    }
}
