using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingScript : MonoBehaviour
{
<<<<<<< HEAD
    // Variï¿½veis
    public float speed;
    //private StartScript startScript;
=======
    // Variáveis
    public float speed;
    private StartScript startScript;
>>>>>>> 189771943d1007e0fc142895cd22b046eec9ac1c

    // Faz o objeto voar
    void Update()
    {
<<<<<<< HEAD
        //startScript = GameObject.Find("GameHandler").GetComponent<StartScript>();

        //if (startScript.canStart)
        
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    
=======
        startScript = GameObject.Find("GameHandler").GetComponent<StartScript>();

        if (startScript.canStart)
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
        }
>>>>>>> 189771943d1007e0fc142895cd22b046eec9ac1c
    }
}
