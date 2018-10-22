using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocionRoja : Pocion {

    // Use this for initialization
    void Start()
    {

        this.nombre = "Poción Roja";
        this.descripcion = "Esta mágica poción permite obtener poderes inimaginables sobre el Fuego";
        this.Habilidad = new FuegoRojo();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void consumir()
    {
        this.Habilidad.lanzar();
    }
}
