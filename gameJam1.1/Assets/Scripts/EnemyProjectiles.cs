using UnityEngine;

public class EnemyProjectiles : MonoBehaviour
{
    [SerializeField] private GameObject[] ammo;
    private int ammoIndex;
    private readonly float firingRate = 3f;
    private PlayerController player;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    
    private void Awake()
    {
        InvokeRepeating("Shoot", 0, firingRate);
    }

    void Shoot()
    {
        if (!player.gameOver)
        {
            ammoIndex = Random.Range(0, ammo.Length);
            Instantiate(ammo[ammoIndex], transform.position, ammo[ammoIndex].transform.rotation);
        }
    }
}
