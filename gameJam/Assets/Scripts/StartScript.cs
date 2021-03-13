using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    public bool canStart = false;
    public bool started = false;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            canStart = true;
        }
    }
}
