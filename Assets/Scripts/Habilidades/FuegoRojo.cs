using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuegoRojo : Habilidad {

	// Use this for initialization
	void Start () {
        this.Daño = 20;
        rb = GetComponent<Rigidbody2D>();
        this.lanzar();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}


    public void lanzar(int idJugador)
    {
        this.IdEjecutor = IdEjecutor;
        rb.AddForce(transform.right * 4000f);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag=="jugador" )
        {
            if (collider.GetComponent<Jugador>().Id == this.IdEjecutor)
            {

            }
            
        }
        Destroy(this.gameObject);
    }

}
