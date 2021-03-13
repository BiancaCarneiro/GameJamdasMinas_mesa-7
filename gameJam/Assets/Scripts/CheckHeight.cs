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
        bgHeight = GameObject.Find("Background").transform.position.y;

        // Inimigo aparece quando o "Player" atinge (background desce) certa altura
        if (bgHeight <= -enemyHeight)
        {
            enemy.SetActive(true);
        }
    }
}
