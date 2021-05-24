using UnityEngine;

public class AmmoImpulse : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float force;
    private readonly float minForce = 1f;
    private readonly float maxForce = 3f;

    void Start()
    {
        // Da um impulso aleatorio para os projeteis assim que sao instanciados
        
        force = Random.Range(minForce, maxForce);
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        rb2d.AddForce(new Vector2(-1, 0) * force, ForceMode2D.Impulse);
    }
}
