using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingScript : MonoBehaviour
{
    // Vari�veis
    public float speed;
    //private StartScript startScript;

    // Faz o objeto voar
    void Update()
    {
        //startScript = GameObject.Find("GameHandler").GetComponent<StartScript>();

        //if (startScript.canStart)
        
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    
    }
}
