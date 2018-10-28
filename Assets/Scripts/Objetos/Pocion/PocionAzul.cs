using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocionAzul : Pocion {

    [SerializeField]
    private GameObject habilidad;

    // Use this for initialization
    void Start()
    {

        this.nombre = "Poción Azul";
        this.descripcion = "Esta mágica poción permite obtener poderes inimaginables sobre el Fuego";
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void OnTriggerStay2D(Collider2D col)
    {
        //si hace trigger enter con un jugador
        if (col.tag == "jugador")
        {
            if (col.GetComponent<Jugador>().Estado == "recogiendo")
            {
                //agregamos la poción roja a su inventario
                col.GetComponent<Inventario>().recibirObjeto(this.gameObject);
                gameObject.SetActive(false);
            }


        }
    }


    public void consumir(int idJugador, Transform transformJugador, float direccion)
    {

        GameObject fuegoRojo = Instantiate(habilidad);
        //habilidad.SetActive(true);

        //habilidad.GetComponent<FuegoRojo>().lanzar(idJugador,transformJugador);
        fuegoRojo.GetComponent<FuegoAzul>().lanzar(idJugador, transformJugador, direccion);

    }
}

