using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocionRoja : Pocion {

    [SerializeField]
    private GameObject habilidad;

    // Use this for initialization
    void Start()
    {

        this.nombre = "Poción Roja";
        this.descripcion = "Esta mágica poción permite obtener poderes inimaginables sobre el Fuego";

    }

    // Update is called once per frame
    void Update()
    {

    }

    void consumir()
    {
        Instantiate(this.habilidad);
    }
}
