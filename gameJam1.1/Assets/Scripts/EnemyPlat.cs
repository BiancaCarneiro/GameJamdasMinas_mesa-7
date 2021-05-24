using UnityEngine;

public class EnemyPlat : MonoBehaviour
{
    public GameObject enemy;
    public Animator anim;
    public Animator animationP;
    private float speed = 3f;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
        if (rb != null) 
        {
            animationP.SetBool("Estado", false);
            anim.SetBool("caindo", true);
            enemy.transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}
