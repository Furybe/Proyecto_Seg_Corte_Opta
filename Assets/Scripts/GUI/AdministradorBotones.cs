using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorBotones : MonoBehaviour {

    /*############################## Botones Escena inicio ##################################*/

    /* Abrir Escena de seleccion de personaje*/

    public void botonSeleccionPersonaje(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Seleccion_Personajes");
    }

    /* Abrir Escena de opciones*/
    public void botonOpciones()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Opciones");
    }

    /*############################## Fin Botones Escena Inicio ###############################*/

    /*############################## Botones Escena Seleccion de personajes ##################*/

    /* Abrir Escena de seleccion de mapa*/
    public void botonSeleccionarMapa()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Seleccion_Mapa");
    }

    /* Volver a escena de inicio*/
    public void botonInicio()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Inicio");
    }

    /*########################### Fin Botones Escena Seleccion de personajes ################*/

    /*############################## Botones Seleccion de mapa ###############################*/

    /* Abrir Escena de Nivel 1*/
    public void botonNivel1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Nivel 1");
    }

    /* Abrir Escena de Nivel 2*/
    public void botonNivel2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Nivel 2");
    }

    /* Abrir Escena de Nivel 3*/
    public void botonNivel3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Nivel 3");
    }

    /*######################### Fin Botones Escena seleccion de mapa ##########################*/

   public void cerrarJuego()
    {
        UnityEngine.Application.Quit();

    }

}
