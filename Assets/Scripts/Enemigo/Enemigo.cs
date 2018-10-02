using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

    //atributos - propiedades de la clase Enemigo
    private int id;
    private string nombre;
    // private Sprite sprite;
    private int daño;
    private float delay;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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

    public float Delay
    {
        get
        {
            return delay;
        }

        set
        {
            delay = value;
        }
    }



  
}
