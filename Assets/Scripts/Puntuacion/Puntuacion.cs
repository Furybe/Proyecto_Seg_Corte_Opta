using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour {

	//atributos - propiedades
	private int puntos;

	public Text puntaje;

	Jugador jugador = new Jugador();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (jugador.Salud < 100)
		{
			//Debug.Log("EL jugador esta perdiendo vida");
			puntuacion();
		}
		
	}
	// funcion que se encarga de sumar los puntos obtenidos en la partida.
	// 1000 puntos por ganar, 100 puntos por matar a otro jugador.
	private void puntuacion(){
		if (jugador.Estado == "muerto")
		{
			Debug.Log("El jugador " + jugador.tag + " Ha muerto por ");
		}

	}
}
