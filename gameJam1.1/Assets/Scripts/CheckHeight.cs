using UnityEngine;

public class CheckHeight : MonoBehaviour
{
    private float bgHeight;
    public float BgHeight => bgHeight;
    private float enemyHeight = 74.35f;
    public float EnemyHeight => enemyHeight;
    [SerializeField] private GameObject enemy;

    void Update()
    {
        bgHeight = GameObject.Find("Background").transform.position.y;

        // Inimigo aparece quando o "Player" atinge (background desce) certa altura
        if (bgHeight <= -enemyHeight)
        {
            BackgroundMovement.desce = false;
            enemy.SetActive(true);
        }
        else
        {
            BackgroundMovement.desce = true;
            enemy.SetActive(false);
        }
    }
}
