﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carnita : Objeto {

	// Use this for initialization
	void Start () {
        this.nombre = "carnita";
        this.descripcion = "Es una poderosa carnita que te dará la fuerza necesaria para ganar";
    }
	
	// Update is called once per frame
	void Update () {
		
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



    public void consumir(GameObject jugador )
    {
        Debug.Log("Inicio consumir carnita");
        gameObject.SetActive(true);
        
            Curar(jugador);
        
       gameObject.SetActive(false);
        Debug.Log("se ha lanzado carnita consumir");
    }

    //funcion para curar de 10 en 10 durante 5 seg, curando un total de 50
    void Curar( GameObject jugador )
    {
   
            jugador.GetComponent<Jugador>().Salud = jugador.GetComponent<Jugador>().Salud + 10;
       
     
        
    }

}