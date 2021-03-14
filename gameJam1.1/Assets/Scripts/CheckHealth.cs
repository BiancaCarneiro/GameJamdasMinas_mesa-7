using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckHealth : MonoBehaviour
{
    // Variaveis
    PlayerController playerController;
    int lastHealth;
    AudioSource hitSound;

    void Start()
    {
        lastHealth = 3; // VIDA MAXIMA
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        hitSound = this.GetComponent<AudioSource>();
    }

    void Update()
    {
        // Checa se o Player tomou dano
        if (playerController.healthSystem.GetHealth() < lastHealth)
        {
            // Some um coracao quando o player e atingido.
            switch (playerController.healthSystem.GetHealth())
            {
                case 0:
                    GameObject.Find("Life").SetActive(false);
                    lastHealth = 0;
                    hitSound.Play();
                    break;
                case 1:
                    GameObject.Find("Heart 2").SetActive(false);
                    lastHealth = 1;
                    hitSound.Play();
                    break;
                case 2:
                    GameObject.Find("Heart 3").SetActive(false);
                    lastHealth = 2;
                    hitSound.Play();
                    break;
                default:
                    break;
            }
        }
    }
}
