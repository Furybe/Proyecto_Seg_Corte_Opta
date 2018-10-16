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

    //salud
    private int salud;

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
