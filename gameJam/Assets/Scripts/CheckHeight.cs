using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckHeight : MonoBehaviour
{
    // Variáveis
    public float bgHeight;
    public GameObject enemy;
    public float enemyHeight;

    void Update()
    {
        // Inimigo aparece se o Player atingir certa altura
        bgHeight = GameObject.Find("Background").transform.position.y;

        if (bgHeight <= -enemyHeight) // Trocar para background mais tarde
        {
            enemy.SetActive(true);
        }
    }
}
