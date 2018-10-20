using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {


    // variable de identificación de la habilidad
    private int id;

    //nombre de la habilidad, mostrado en el mapa
    private string nombre;

    //descripción de lo que hace la habilidad
    private string descripcion;

    public string Nombre
    {
        get
        {
            return nombre;
        }

        set
        {
            nombre = value;
        }
    }

    public string Descripcion
    {
        get
        {
            return descripcion;
        }

        set
        {
            descripcion = value;
        }
    }

    public int Id
    {
        get
        {
            return id;
        }

        set
        {
            id = value;
        }
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //ejecuta la habilidad correspondiente
    void ejecutarHabilidad()
    {

    }
}
