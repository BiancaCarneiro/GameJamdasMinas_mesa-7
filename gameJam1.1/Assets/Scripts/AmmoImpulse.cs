using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoImpulse : MonoBehaviour
{
    Rigidbody2D rb2d;
    private float force;
    public float minForce;
    public float maxForce;
    // Start is called before the first frame update
    void Start()
    {
        force = Random.Range(minForce, maxForce);
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        rb2d.AddForce(new Vector2(-1, 0) * force, ForceMode2D.Impulse);
    }
}
