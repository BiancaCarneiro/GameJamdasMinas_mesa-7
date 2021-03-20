using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawn : MonoBehaviour
{
    private Vector3 bounds;
    public static int colisoes = 0;
    public GameObject platform;
    float prop = 3/10;
    float limiteX = 3f;

    void Update()
    {
        bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        if (colisoes > 0)//spawna uma plataforma toda vez que o pesonagem bate em uma plataforma
        {
            var position = new Vector3(Random.Range(-limiteX, limiteX), 5, 0);
            GameObject plat = Instantiate(platform, position, Quaternion.identity);
            colisoes--;
        }
    }
}
