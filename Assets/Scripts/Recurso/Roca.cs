using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roca : Recurso {

    [SerializeField]
    private GameObject martillito;

    // Use this for initialization
    void Start () {

        this.nombreMaterial = "piedra";
        this.cantidadMaterial = 300;

        //desactivamos el objeto martillito
        this.martillito.SetActive(false);

        //incializamos las propiedades
      
            
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        comprobarDestruirRecurso();
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        //activamos el martillo para que se muestre en la scene que es un objeto Farmeable
        if (collider.tag=="jugador")
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
        if (collider.tag=="jugador")
        {
            martillito.SetActive(false);
        }
        
    }

  

}
