using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorBotones : MonoBehaviour
{
    // Abrir escena de seleccion de personajes.
    public void botonSelectPersonajes()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scene002_Seleccion_Personajes");
    }

    // Abrir escena de opciones.
    public void botonOpcion()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Opciones");
    }
    //Salir del juego
    public void Salida()
    {
        UnityEngine.Application.Quit();
    }
}
