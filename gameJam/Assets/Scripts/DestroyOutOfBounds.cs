using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds  : MonoBehaviour
{
    private Vector3 bounds;
    public float tolerance = 1f;

    void Update()
    {
        if (transform.position.y < -GetBounds().y - tolerance || transform.position.y > GetBounds().y + tolerance)
        {
            Destroy(gameObject);
        }
    }

    public Vector3 GetBounds()
    {
        bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        return bounds;
    }
}
