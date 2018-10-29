using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Construccion : MonoBehaviour {

    private SpriteRenderer sprite;

    [SerializeField]
    private GameObject herramientaArriba;

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
        
      if (Input.GetKey(KeyCode.O))
      {
          construirArriba();
      }
      
        if (Input.GetKeyDown(KeyCode.O))
      {
          construirArriba();
      }
      
        //Debug.Log(herramientaArriba.transform.position.x + "    "+ herramientaArriba.transform.position.y);

    }

    void construirArriba()
    {
        Debug.Log("entró construccion");
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
