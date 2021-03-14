using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectiles : MonoBehaviour
{
    // Variaveis
    public GameObject[] ammo;
    private int ammoRandomizer;
    public float rate = 1f;
    private PlayerController playerController;
    AudioSource shootSound;

    private void Start()
    {
        shootSound = this.GetComponent<AudioSource>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    // Inimigo ficara atirando em um ritmo determinado
    private void Awake()
    {
        InvokeRepeating("Ammo", 0, rate);
    }

    void Ammo()
    {
        // Se o jogo nao tiver acabado, faça algo
        if (!playerController.gameOver)
        {
            // Randomiza e instancia o projetil
            ammoRandomizer = Random.Range(0, ammo.Length);
            Instantiate(ammo[ammoRandomizer], this.transform.position, ammo[ammoRandomizer].transform.rotation);
            shootSound.Play();
        }
    }
}
