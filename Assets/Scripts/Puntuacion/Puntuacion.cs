using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour {

	//atributos - propiedades
	private int puntos;

	public Text puntaje;

	public Jugador jugador = new Jugador();
	
	// Update is called once per frame
	void Update () {
		/*
		if (jugador.Salud == 100f)
		{
			Debug.Log("El jugador esta perdiendo vida");
			puntuacion();
			puntaje.text = jugador.Salud.ToString("0");
		}
		*/
	}
	// funcion que se encarga de sumar los puntos obtenidos en la partida.
	// 1000 puntos por ganar, 100 puntos por matar a otro jugador.
	private void puntuacion(){
		if (jugador.Estado == "vivo")
		{
			Debug.Log("El jugador " + jugador.Id + " ha ganado 100 puntos");
		}

	}
}
