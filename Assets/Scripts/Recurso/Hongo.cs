using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hongo : Recurso {


    private List<Objeto> objectosDropeados;
    private int salud = 30;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

    public void bajarSalud()
    {
        this.salud = salud - 10;
        if (this.salud==0)
        {
            dropearItems();
        }
    }

    public void dropearItems()
    {
        Debug.Log("dropeado");

        Destroy(gameObject);
    }


}
