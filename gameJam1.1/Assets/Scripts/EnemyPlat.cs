using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlat : MonoBehaviour
{
    public GameObject enemy;
    public Animator animation;
    public Animator animationP;
    public float speed = 3f;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
        if (rb != null) 
        {
            animationP.SetBool("Estado", false);
            animation.SetBool("caindo", true);
            enemy.transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
