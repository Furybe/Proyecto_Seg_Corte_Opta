using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstruirArriba : Construir {

	// Use this for initialization
	void Start () {
        this.construible = true;
	}
	
	// Update is called once per frame
	void Update () {
		
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
