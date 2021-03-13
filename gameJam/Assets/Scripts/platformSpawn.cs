using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawn : MonoBehaviour
{
    public static int colisoes = 0;
    public GameObject platform;
    
    void Update()
    {
        if(colisoes > 0){
            var position = new Vector3(Random.Range(-3f, 3.2f), 5.5f, 0);
            GameObject plat = Instantiate(platform, position, Quaternion.identity);
            colisoes--;
        }
    }
}
