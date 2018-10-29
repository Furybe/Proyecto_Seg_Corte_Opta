using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Construccion : MonoBehaviour
{

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

    [SerializeField]
    private GameObject cuadroPiedra;

    [SerializeField]
    private GameObject cuadroMetal;

    private GameObject cuadroSeleccionado;
    private Boolean recursoSuficiente;
    // Use this for initialization
    void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();
        this.cuadroSeleccionado = cuadroMadera;
        this.recursoSuficiente = false;


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        verificarRecurso();
        buscarBloqueMaterialSuficiente();

        //input construccion arriba
        if (Input.GetKey(KeyCode.U))
        {
            construirArriba();
        }
/*
        if (Input.GetKeyDown(KeyCode.U))
        {
            construirArriba();
        }
*/
        //input construccion abajo
        if (Input.GetKey(KeyCode.J))
        {
            construirAbajo();
        }
/*
        if (Input.GetKeyDown(KeyCode.J))
        {
            construirAbajo();
        }
        */

        //input construccion izquierda
        if (Input.GetKey(KeyCode.H))
        {
            if (transform.localScale.x == -1)
            {
                construirDerecha();
            }
            else
            {
                construirIzquierda();
            }

        }
    
        /*
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (transform.localScale.x == -1)
            {
                construirDerecha();
            }
            else
            {
                construirIzquierda();
            }
        }
*/
        //input construccion derecha
        if (Input.GetKey(KeyCode.K))
        {
            if (transform.localScale.x == -1)
            {
                construirIzquierda();
            }
            else
            {
                construirDerecha();
            }
        }

        /*
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (transform.localScale.x == -1)
            {
                construirIzquierda();
            }
            else
            {
                construirDerecha();
            }
        }
        */

        //inputs para cambiar el material de construcción
        //seleccionar madera como material de construccion
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            cuadroSeleccionado = cuadroMadera;
            verificarRecurso();
        }

        //seleccionar piedra como material de construccion
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            cuadroSeleccionado = cuadroPiedra;
            verificarRecurso();
        }

        //seleccionar metal como material de construccion
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            cuadroSeleccionado = cuadroMetal;
            verificarRecurso();
        }


    }

    void construirArriba()
    {
        if (herramientaArriba.GetComponent<ConstruirArriba>().construible)
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

            //construimos le objeto si existen suficientes recursos
            if (recursoSuficiente)
            {
                if (consumirMaterial())
                {
                    //creamos el bloque
                    Instantiate(cuadroSeleccionado, new Vector3(posicionX, posicionY, 0), Quaternion.identity);

                }

            }
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

            if (recursoSuficiente)
            {
                if (consumirMaterial())
                {
                    Instantiate(cuadroSeleccionado, new Vector3(posicionX, posicionY, 0), Quaternion.identity);

                }


            }
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


        if (recursoSuficiente)
        {
            if (consumirMaterial())
            {
                Instantiate(cuadroSeleccionado, new Vector3(posicionX, posicionY, 0), Quaternion.identity);
            }
        

        }

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

        if (recursoSuficiente)
        {
            if (consumirMaterial())
            {
                Instantiate(cuadroSeleccionado, new Vector3(posicionX, posicionY, 0), Quaternion.identity);

            }

        }

    }

    void verificarRecurso()
    {
        switch (cuadroSeleccionado.tag)
        {
            case "bloqueMadera":
                if (gameObject.GetComponent<Jugador>().Madera >= 10)
                {
                    recursoSuficiente = true;
                }
                else
                {
                    recursoSuficiente = false;
                }
                break;

            case "bloquePiedra":
                if (gameObject.GetComponent<Jugador>().Piedra >= 10)
                {
                    recursoSuficiente = true;
                }
                else
                {
                    recursoSuficiente = false;
                }
                break;

            case "bloqueMetal":
                if (gameObject.GetComponent<Jugador>().Metal >= 10)
                {
                    recursoSuficiente = true;
                }
                else
                {
                    recursoSuficiente = false;
                }
                break;
            default:
                break;
        }

    }

    //gastar material al construir bloque
    private bool consumirMaterial()
    {
        if (cuadroSeleccionado.tag == "bloqueMadera")
        {

            if (gameObject.GetComponent<Jugador>().Madera >= 10)
            {
                gameObject.GetComponent<Jugador>().Madera = gameObject.GetComponent<Jugador>().Madera - 10;

                return true;
            }
            else
            {
                return false;
            }
        }


        if (cuadroSeleccionado.tag == "bloquePiedra")
        {

            if (gameObject.GetComponent<Jugador>().Piedra >= 10)
            {
                gameObject.GetComponent<Jugador>().Piedra = gameObject.GetComponent<Jugador>().Piedra - 10;

                return true;
            }
            else
            {
                return false;
            }

        }
        if (cuadroSeleccionado.tag == "bloqueMetal")
        {
            if (gameObject.GetComponent<Jugador>().Metal >= 10)
            {
                gameObject.GetComponent<Jugador>().Metal = gameObject.GetComponent<Jugador>().Metal - 10;
                return true;
            }
            else
            {
                return false;
            }

        }

        return false;
    }

    private void buscarBloqueMaterialSuficiente()
    {
        if (recursoSuficiente==false)
        {
            if (gameObject.GetComponent<Jugador>().Madera>10)
            {
                cuadroSeleccionado = cuadroMadera;
                verificarRecurso();
                return;
            }

            if (gameObject.GetComponent<Jugador>().Piedra > 10)
            {
                cuadroSeleccionado = cuadroPiedra;
                verificarRecurso();
                return;
            }
            if (gameObject.GetComponent<Jugador>().Metal > 10)
            {
                cuadroSeleccionado = cuadroMetal;
                verificarRecurso();
                return;
            }
        }
    }

}
