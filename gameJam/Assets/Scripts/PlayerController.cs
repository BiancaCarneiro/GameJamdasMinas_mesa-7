using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variaveis
    public float horizontalInput;
    public float speed = 6f;
    public float bounds = 2.55f;

    void Start()
    {
        
    }


    void Update()
    {
        // Movimento do Player
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2(1, 0) * horizontalInput * speed * Time.deltaTime);

        // Limita o movimento do Player
        if (transform.position.x < -bounds)
        {
            transform.position = new Vector2(-bounds, transform.position.y);
        }
        if (transform.position.x > bounds)
        {
            transform.position = new Vector2(bounds, transform.position.y);
        }
    }
}
