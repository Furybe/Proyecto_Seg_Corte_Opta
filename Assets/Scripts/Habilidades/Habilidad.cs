using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Habilidad : MonoBehaviour {

    //propiedades
    private int id;
    private string nombre;
    private int idEjecutor;
    private int daño;

    protected Rigidbody2D rb;

    // Use this for initialization
    void Start () {

       
     

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    
    //lanzamos la habilidad
    public void lanzar()
    {
    }

    protected int Id
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

    protected string Nombre
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

    protected int IdEjecutor
    {
        get
        {
            return idEjecutor;
        }

        set
        {
            idEjecutor = value;
        }
    }

    public int Daño
    {
        get
        {
            return daño;
        }

        set
        {
            daño = value;
        }
    }
}
