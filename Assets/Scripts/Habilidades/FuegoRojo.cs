using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuegoRojo : Habilidad {

    [SerializeField]
    private Rigidbody2D rb;


	// Use this for initialization
	void Start () {
        this.Daño = 20;

        rb = GetComponent<Rigidbody2D>();
        //gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}


    public void lanzar(int idJugador, Transform transformJugador)
    {
        
        gameObject.SetActive(true);
        gameObject.transform.position = transformJugador.position;
        this.IdEjecutor = idJugador;

        rb.AddForce(transform.right * 4000f);
        Debug.Log("habilidad lanzada");
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
