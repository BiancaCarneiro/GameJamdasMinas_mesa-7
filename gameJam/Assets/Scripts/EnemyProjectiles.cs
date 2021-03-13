using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectiles : MonoBehaviour
{
    // Vari�veis
    public GameObject[] ammo;
    private int ammoRandomizer;
    public float rate = 1f;

    // Inimigo ficar� atirando em um ritmo determinado
    private void Awake()
    {
        InvokeRepeating("Ammo", 0, rate);
    }

    void Ammo()
    {
        // Randomiza e instancia o proj�til
        ammoRandomizer = Random.Range(0, ammo.Length);
        Instantiate(ammo[ammoRandomizer], this.transform.position, ammo[ammoRandomizer].transform.rotation);
    }
}
