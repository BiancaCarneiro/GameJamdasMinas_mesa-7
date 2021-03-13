using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectiles : MonoBehaviour
{
    // Variáveis
    public GameObject[] ammo;
    private int ammoRandomizer;
    public float rate = 1f;
    private PlayerController playerController;

    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    // Inimigo ficará atirando em um ritmo determinado
    private void Awake()
    {
        InvokeRepeating("Ammo", 0, rate);
    }

    void Ammo()
    {
        // Se o jogo não tiver acabado, faça algo
        if (!playerController.gameOver)
        {
            // Randomiza e instancia o projétil
            ammoRandomizer = Random.Range(0, ammo.Length);
            Instantiate(ammo[ammoRandomizer], this.transform.position, ammo[ammoRandomizer].transform.rotation);
        }
    }
}
