using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variáveis
    public float horizontalInput;
    public float speed;

    void Start()
    {
        
    }


    void Update()
    {
        // Movimento do Player
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2(1, 0) * horizontalInput * speed * Time.deltaTime);
    }
}
