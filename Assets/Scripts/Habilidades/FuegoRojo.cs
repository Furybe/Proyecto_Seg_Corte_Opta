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
    }
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}


    public void lanzar(int idJugador, Transform transformJugador, float direccion)
    {
        
        
        gameObject.transform.position = transformJugador.position;
 
        this.IdEjecutor = idJugador;
        if (direccion==1)
        {
            rb.AddForce(transform.right * 4000f);

        }
        else
        {
            //agregamos la fuerza al gameobject
            rb.AddForce(-transform.right* 4000f);
            
            //giramos el gameObject para que la animación se vea correcta
            transform.localScale=new Vector3(-1, 1, 1);
        }
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
        //Destroy(this.gameObject);
    }

}
