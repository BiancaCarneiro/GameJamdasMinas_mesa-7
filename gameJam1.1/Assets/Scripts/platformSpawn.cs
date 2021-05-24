using UnityEngine;

public class platformSpawn : MonoBehaviour
{
    public static int colisoes;
    public GameObject platform;
    private readonly float limiteX = 3f;

    void Update()
    {
        if (colisoes > 0) //spawna uma plataforma toda vez que o pesonagem bate em uma plataforma
        {
            var position = new Vector3(Random.Range(-limiteX, limiteX), 5, 0);
            Instantiate(platform, position, Quaternion.identity);
            colisoes--;
        }
    }
}
