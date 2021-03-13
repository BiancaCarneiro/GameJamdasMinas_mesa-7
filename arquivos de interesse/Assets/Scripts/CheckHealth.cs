using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckHealth : MonoBehaviour
{
    PlayerController playerController;
    int lastHealth;

    void Start()
    {
        lastHealth = 3; // VIDA MÁXIMA
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        // Checa se o Player tomou dano
        if (playerController.healthSystem.GetHealth() < lastHealth)
        {
            // Some um coração quando o player é atingido.
            switch (playerController.healthSystem.GetHealth())
            {
                case 0:
                    GameObject.Find("Life").SetActive(false);
                    lastHealth = 0;
                    break;
                case 1:
                    GameObject.Find("Heart 2").SetActive(false);
                    lastHealth = 1;
                    break;
                case 2:
                    GameObject.Find("Heart 3").SetActive(false);
                    lastHealth = 2;
                    break;
                default:
                    break;
            }
        }
    }
}
