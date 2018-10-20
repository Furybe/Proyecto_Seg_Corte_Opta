using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbol : Recurso {

    [SerializeField]
    private GameObject martillito;
    // Use this for initialization
    void Start()
    {
        //desacticamos el martillito para que no se muestre la animación por defecto
        this.martillito.SetActive(false);

        //inicializamos propiedades
        this.cantidadMaterial = 200;
        this.nombreMaterial = "madera";

    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }


    void OnTriggerStay2D(Collider2D collider)
    {
        //activamos el martillo para que se muestre en la scene que es un objeto Farmeable
        if (collider.tag == "jugador")
        {
            this.martillito.SetActive(true);
            //comprobamos si está farmeando
            if (collider.GetComponent<Jugador>().Estado == "farmeando")
            {
                collider.GetComponent<Jugador>().recibirMaterial(this.nombreMaterial, DropearMaterial());
                Debug.Log(this.cantidadMaterial);
            }

            comprobarDestruirRecurso();

        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        //desactivamos el martillo cuando el jugador se aleje de la piedra
        if (collider.tag == "jugador")
        {
            martillito.SetActive(false);
        }

    }

}
