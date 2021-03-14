using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platInicial : MonoBehaviour
{
    float counterT = 5;    
    float speed = 3f;
    public GameObject platform;
    public float jumpForce = 10f;


    void OnCollisionEnter2D(Collision2D collision)
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

    void Update()
    {
        if (counterT > 0) counterT -= Time.deltaTime;
        if (counterT <= 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, transform.position.y - speed), speed * Time.deltaTime);
        }
        if (platform.transform.position.y < -6)
        {
            Destroy(platform);
        }
    }
}
