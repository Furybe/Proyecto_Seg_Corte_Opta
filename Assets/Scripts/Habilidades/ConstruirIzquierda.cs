using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstruirIzquierda : Construir {

    // Use this for initialization
    void Start()
    {
        this.construible = true;
    }

    // Update is called once per frame

    void FixedUpdate()
    {

       
    }
    void OnTriggerStay2D(Collider2D other)
    {
        this.construible = false;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        this.construible = true;
    }
}
