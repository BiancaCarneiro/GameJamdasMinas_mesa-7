using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawn : MonoBehaviour
{
    public static bool destroyed = true;
    public GameObject platform;
    public Transform pointSpaw;
    
    void Update()
    {
        if(destroyed){ // ele ve se a plataforma anterior foi destruida, se sim, cria uma nova
            destroyed = false;
            GameObject plat = Instantiate(platform, pointSpaw.position, pointSpaw.rotation);
        }
    }
}
