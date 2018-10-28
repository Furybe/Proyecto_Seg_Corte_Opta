using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuegoFucsia : Habilidad {

    [SerializeField]
    private Rigidbody2D rb;
    private float velocidadFuego;

    // Use this for initialization
    void Start()
    {

        //inicializando propiedades
        this.Daño = 35;
        this.velocidadFuego = 6000f;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    public void lanzar(int idJugador, Transform transformJugador, float direccion)
    {


        this.IdEjecutor = idJugador;
        if (direccion == 1)
        {
            rb.AddForce(transform.right * 6000f);
            this.gameObject.transform.position = new Vector3(transformJugador.position.x + 3f, transformJugador.position.y + 3f, transformJugador.position.z);

        }
        else
        {
            this.gameObject.transform.position = new Vector3(transformJugador.position.x - 3f, transformJugador.position.y + 3f, transformJugador.position.z);

            //agregamos la fuerza al gameobject
            rb.AddForce(-transform.right * 6000f);

            //giramos el gameObject para que la animación se vea correcta
            transform.localScale = new Vector3(-1, 1, 1);
        }
        Debug.Log("habilidad lanzada");
        Destroy(gameObject, 3.0f);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "jugador")
        {
            Debug.Log("entró xd jugador");
            if (collider.GetComponent<Jugador>().Id == this.IdEjecutor)
            {

            }
            else
            {

            }

        }
        else
        {

        }

    }
}
