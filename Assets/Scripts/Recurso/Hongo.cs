using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hongo : Recurso {


    protected List<Objeto> objectosDropeados = new List<Objeto>();
    protected int salud = 30;
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
            DropearItems();
        }
    }

    public  void DropearItems()
    {
        Debug.Log("dropeado");

        Destroy(gameObject);
    }


}
