using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawn : MonoBehaviour
{
    private Vector3 bounds;
    public static int colisoes = 0;
    public GameObject platform;
    private float tolerance = 0.5f;

    void Update()
    {
        bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

        if (colisoes > 0)
        {
            var position = new Vector3(Random.Range(bounds.x, -bounds.x), bounds.y + tolerance, 0);
            GameObject plat = Instantiate(platform, position, Quaternion.identity);
            colisoes--;
        }
    }
}
