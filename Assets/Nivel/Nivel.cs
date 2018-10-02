using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel : MonoBehaviour {


    //atributos - propiedades de la clase nivel
    private int id;
    private string nivelDificultad;
    private string listaEnemigos;


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

    public string NivelDificultad
    {
        get
        {
            return nivelDificultad;
        }

        set
        {
            nivelDificultad = value;
        }
    }


  
}
