using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScroll : MonoBehaviour
{
    public static bool colidiu = true; // essa variável vai mandar a info se o objeto colidiu ou nao
    float speed = 1f;
    Vector2 pos;
    public GameObject platform;
    void Start()
    {
        pos = platform.transform.position; // Salva a pos inicial    
    }

    // Update is called once per frame
    void Update()
    {
        if(colidiu){ // Se colidiu com a plataforma, a plataforma desce
            float newPos = speed * Time.deltaTime;
            pos += Vector2.down;
            platform.transform.position = Vector2.MoveTowards(transform.position, pos, newPos);// move para baixo
        }
        if(platform.transform.position.y < -6){
            //platformSpawn.destroyed = true;
            Destroy(platform);
        }
    }
}
