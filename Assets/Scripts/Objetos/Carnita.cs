using System.Collections;
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

    public void consumir(GameObject jugador )
    {
        for (int i = 0; i < 5; i++)
        {
            StartCoroutine(Curar(jugador));
        }
    }

    //funcion para curar de 10 en 10 durante 5 seg, curando un total de 50
    IEnumerator Curar( GameObject jugador)
    {
      
        jugador.GetComponent<Jugador>().Salud = jugador.GetComponent<Jugador>().Salud + 10;
        yield return new WaitForSeconds(1);
      
    }

}
