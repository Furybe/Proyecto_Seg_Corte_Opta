using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TiempoJuego : MonoBehaviour {

	public Text tiempo;
	private float minutos;
	private float segundos;
	//Esta variable tipo string es la que va al metodo que lo sube a la DB
	//El valor se pasa a entero y se divide entre 3600 para saber el tiempo total de juego en H
	private string tiempoDeJuego;
	void Awake () {
		
	}
	
	void Update () {
		tiempoDeJuego = ""+ Time.timeSinceLevelLoad.ToString("f0");
		ActualizacionTiempo();
		//test metodo paso a integer
		if(tiempoDeJuego == "35"){
			pasoInt(tiempoDeJuego);
		}
	}
	//metodo que muestra el tiempo de una forma mas comoda para el usuario
	public void ActualizacionTiempo(){
		minutos = (int)(Time.timeSinceLevelLoad/60f);
		segundos = (int)(Time.timeSinceLevelLoad%60f);
		tiempo.text = minutos.ToString("00") + ":" + segundos.ToString("00");
	}
	//Metodo para pasar el tiempo de string a entero
	public void pasoInt(string t){
		int i = 0;
		try
		{
   			i = System.Convert.ToInt32(t);
		}
		catch (FormatException e)
		{
			Debug.Log("El valor no representa un entero valido " + e);
		}
		catch (OverflowException e)
		{
			Debug.Log("El valor es un entero valido pero es demasiado grande. recm: usar Convert.ToInt64  " + e);
		}
	}
}
