using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformScroll : MonoBehaviour
{
    public static int colidiu; // essa variável vai mandar a info se o objeto colidiu ou nao
    public float jumpForce = 10f;
    float speed = 3f;
    public GameObject platform;

    void Start()
    {
        colidiu = 0;
    }  
    
    void OnCollisionEnter2D(Collision2D collision)
    {

        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
        if (rb != null){
            platformSpawn.colisoes++;
            Vector2 velocity = rb.velocity;
            velocity.y = jumpForce;
            rb.velocity = velocity;
        }
    }

    // Update is called once per frame
    void Update()//
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, transform.position.y - speed), speed*Time.deltaTime);
        if(platform.transform.position.y < -6){
            Destroy(platform);
        }
    }
}
