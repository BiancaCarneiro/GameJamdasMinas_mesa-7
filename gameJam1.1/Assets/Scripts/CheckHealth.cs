using UnityEngine;

public class CheckHealth : MonoBehaviour
{
    private PlayerController player;
    private int lastHealth;
    private AudioSource hitSound;

    void Start()
    {
        lastHealth = 3; // VIDA MAXIMA
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        hitSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (player.healthSystem.GetHealth() < lastHealth)
        {
            UpdateHealth();
        }
    }

    private void UpdateHealth()
    {
        switch (player.healthSystem.GetHealth())
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
        }
    }
}
