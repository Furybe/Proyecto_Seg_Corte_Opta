using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Construccion : MonoBehaviour {

    private SpriteRenderer sprite;

    [SerializeField]
    private GameObject herramientaArriba;
    [SerializeField]
    private GameObject herramientaAbajo;
    [SerializeField]
    private GameObject herramientaDerecha;
    [SerializeField]
    private GameObject herramientaIzquierda;


    [SerializeField]
    private GameObject cuadroMadera;
/*
    [SerializeField]
    private GameObject cuadroPiedra;

    [SerializeField]
    private GameObject cuadroMetal;
    */
    // Use this for initialization
    void Start () {
        sprite = gameObject.GetComponent<SpriteRenderer>();
       
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
        //input construccion arriba
      if (Input.GetKey(KeyCode.U))
      {
          construirArriba();
      }
      
        if (Input.GetKeyDown(KeyCode.U))
      {
          construirArriba();
      }

        //input construccion abajo
        if (Input.GetKey(KeyCode.J))
        {
            construirAbajo();
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            construirAbajo();
        }

        //input construccion izquierda
        if (Input.GetKey(KeyCode.H))
        {
            construirIzquierda();
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            construirIzquierda();
        }

        //input construccion derecha
        if (Input.GetKey(KeyCode.K))
        {
            
            construirDerecha();
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            construirDerecha();
        }

        //input construccion abajo

        //Debug.Log(herramientaArriba.transform.position.x + "    "+ herramientaArriba.transform.position.y);

    }

    void construirArriba()
    {
        if (herramientaArriba.GetComponent<ConstruirArriba>().construible )
        {

       
        //obtenemos las posiciones de la herramienta arriba para decidir donde poner 
        //la construcción
        int posicionX = (int)herramientaArriba.transform.position.x;
        int posicionY = (int)herramientaArriba.transform.position.y;

        //covertimos a arreglos de char para facilitar el trabajo
        char[] xArray = posicionX.ToString().ToCharArray();
        char[] yArray = posicionY.ToString().ToCharArray();

        //cambiamos el último dígito por 5 (para centrar en la cuadrícula)
        xArray[xArray.Length - 1] = '5';
        yArray[yArray.Length - 1] = '5';

      
        //obtenemos el nuevo número 
        posicionX = Int32.Parse(new string(xArray));
        posicionY = Int32.Parse(new string(yArray));

        Instantiate(cuadroMadera, new Vector3(posicionX, posicionY, 0),Quaternion.identity);
        }
    }


    void construirAbajo()
    {
        if (herramientaAbajo.GetComponent<ConstruirAbajo>().construible)
        {
        //obtenemos las posiciones de la herramienta arriba para decidir donde poner 
        //la construcción
        int posicionX = (int)herramientaAbajo.transform.position.x;
        int posicionY = (int)herramientaAbajo.transform.position.y;

        //covertimos a arreglos de char para facilitar el trabajo
        char[] xArray = posicionX.ToString().ToCharArray();
        char[] yArray = posicionY.ToString().ToCharArray();

        //cambiamos el último dígito por 5 (para centrar en la cuadrícula)
        xArray[xArray.Length - 1] = '5';
        yArray[yArray.Length - 1] = '5';


        //obtenemos el nuevo número 
        posicionX = Int32.Parse(new string(xArray));
        posicionY = Int32.Parse(new string(yArray));

        Instantiate(cuadroMadera, new Vector3(posicionX, posicionY, 0), Quaternion.identity);
        }
    }

    void construirDerecha()
    {

        //obtenemos las posiciones de la herramienta arriba para decidir donde poner 
        //la construcción
        int posicionX = (int)herramientaDerecha.transform.position.x;
        int posicionY = (int)herramientaDerecha.transform.position.y;

        //covertimos a arreglos de char para facilitar el trabajo
        char[] xArray = posicionX.ToString().ToCharArray();
        char[] yArray = posicionY.ToString().ToCharArray();

        //cambiamos el último dígito por 5 (para centrar en la cuadrícula)
        xArray[xArray.Length - 1] = '5';
        yArray[yArray.Length - 1] = '5';


        //obtenemos el nuevo número 
        posicionX = Int32.Parse(new string(xArray));
        posicionY = Int32.Parse(new string(yArray));

        Instantiate(cuadroMadera, new Vector3(posicionX, posicionY, 0), Quaternion.identity);

    }

    void construirIzquierda()
    {

        //obtenemos las posiciones de la herramienta arriba para decidir donde poner 
        //la construcción
        int posicionX = (int)herramientaIzquierda.transform.position.x;
        int posicionY = (int)herramientaIzquierda.transform.position.y;

        //covertimos a arreglos de char para facilitar el trabajo
        char[] xArray = posicionX.ToString().ToCharArray();
        char[] yArray = posicionY.ToString().ToCharArray();

        //cambiamos el último dígito por 5 (para centrar en la cuadrícula)
        xArray[xArray.Length - 1] = '5';
        yArray[yArray.Length - 1] = '5';


        //obtenemos el nuevo número 
        posicionX = Int32.Parse(new string(xArray));
        posicionY = Int32.Parse(new string(yArray));

        Instantiate(cuadroMadera, new Vector3(posicionX, posicionY, 0), Quaternion.identity);

    }

}
