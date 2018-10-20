using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

    //atributos - propiedades de la clase Enemigo
    // id para identificar los distintos tipos de enemigos
    private int id;
   
    //nombre para identificar el objeto en juego
    private string nombre;

    // private Sprite sprite;
    private int daño;

    //variable usada para representar el tiempo de espera para lanzar una habilidad de nuevo
    private float delay;

    //representa la salud que posee el enemigo en el juego
    private int salud;

    //variable para especificar aquellos enemigos que son destruibles dentro del juego y los que no
    private bool destruible;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //funcion atacar, vacía ya que se sobrescribe en cada una de las clases hijas
    void atacar()
    {

    }

    //funcion activada se recibe daño del ataque de un jugador
    void recibirDaño()
    {

    }

    //funcion para eliminar el objeto del juego, principalmente usado cualdo el valor de la salud sea 0
    void destruir()
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

    public int Salud
    {
        get
        {
            return salud;
        }

        set
        {
            salud = value;
        }
    }

    public bool Destruible
    {
        get
        {
            return destruible;
        }

        set
        {
            destruible = value;
        }
    }
}
