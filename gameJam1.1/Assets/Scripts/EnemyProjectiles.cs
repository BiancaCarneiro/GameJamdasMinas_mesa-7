using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectiles : MonoBehaviour
{
    // Vari�veis
    public GameObject[] ammo;
    private int ammoRandomizer;
    public float rate = 1f;
    private PlayerController playerController;

    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    // Inimigo ficar� atirando em um ritmo determinado
    private void Awake()
    {
        InvokeRepeating("Ammo", 0, rate);
    }

    void Ammo()
    {
        // Se o jogo n�o tiver acabado, fa�a algo
        if (!playerController.gameOver)
        {
            // Randomiza e instancia o proj�til
            ammoRandomizer = Random.Range(0, ammo.Length);
            Instantiate(ammo[ammoRandomizer], this.transform.position, ammo[ammoRandomizer].transform.rotation);
        }
    }
}
