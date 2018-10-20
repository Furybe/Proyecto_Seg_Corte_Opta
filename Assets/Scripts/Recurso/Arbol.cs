using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbol : Recurso {

    [SerializeField]
    private GameObject martillito;
    // Use this for initialization
    void Start()
    {

        this.martillito.SetActive(false);



    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D collider)
    {
        //activamos el martillo para que se muestre en la scene que es un objeto Farmeable
        if (collider.tag == "jugador")
        {
            this.martillito.SetActive(true);

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
