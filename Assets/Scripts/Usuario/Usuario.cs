using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Usuario : MonoBehaviour {

    //atributos - propiedades de la clase usuario

    private int id;
    private string email;
    private string contraseña;
    private string estado;
    private string nombre;
    // usuario que se usarà para gestionar la cuenta
    private string usuario;
    private DateTime fechaRegistro;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public bool login()
    {
        //función de loggin
        return true;

    }

    public bool logout()
    {
        // code función de logout
        return true;
    }

    public bool cambiarProyecto (){
        //code función cambio de correo

        return true;
    }

    public bool recuperarContraseña (){
        return true;
    }



}
