using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Puntuacion : MonoBehaviour {

	//atributos - propiedades
	private int puntosporkill = 100;

	public Text puntaje;

	// Use this for initialization
	void Start () {
		puntaje.text = puntosporkill.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	// funcion que se encarga de sumar los puntos obtenidos en la partida.
	// 1000 puntos por ganar, 100 puntos por matar a otro jugador.
	public void puntuacion(){
		//puntosporkill = puntosporkill + 100;
		puntaje.text = puntosporkill.ToString();
		Debug.Log("Se han sumando 100 puntos al jugador: x");
	}
}
