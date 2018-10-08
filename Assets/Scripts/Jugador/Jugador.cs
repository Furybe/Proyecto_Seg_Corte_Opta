using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {


    //atributos - propiedades
    private int id;
    private int salud;
    private string estado;
    private Personaje personaje;
    private float poder;
    private float velocidadMovimiento = 100f;
    private float velocidadAtaque;

    private Rigidbody2D rb;
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame


    void FixedUpdate()
    {
        anim.SetFloat("velocidad", Mathf.Abs(rb.velocity.x));
        anim.SetFloat("velocidadVertical", Mathf.Abs(rb.velocity.y));
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector2 movimiento = new Vector2(moveHorizontal, 0);

        
        rb.AddForce(movimiento * velocidadMovimiento);
        
          
       

        if (Input.GetKeyDown("space"))
        {
            saltar();
        }

       
        if (Input.GetKeyDown(KeyCode.L))
        {
            recogerTirar();
        }


    }

    void saltar() {       

        Vector2 salto = new Vector2(0, 35);
        rb.AddForce( salto * velocidadMovimiento);

    }

    public void recogerTirar() {

        anim.SetBool("atacando", true);

    }


    public int Id
    {
        get
        {
            return id;
        }

        set
        {
            id = value;
        }
    }

    public int Salud
    {
        get
        {
            return salud;
        }

        set
        {
            salud = value;
        }
    }

    public string Estado
    {
        get
        {
            return estado;
        }

        set
        {
            estado = value;
        }
    }

    public Personaje Personaje
    {
        get
        {
            return personaje;
        }

        set
        {
            personaje = value;
        }
    }

    public float Poder
    {
        get
        {
            return poder;
        }

        set
        {
            poder = value;
        }
    }

    public float VelocidadMovimiento
    {
        get
        {
            return velocidadMovimiento;
        }

        set
        {
            velocidadMovimiento = value;
        }
    }

    public float VelocidadAtaque
    {
        get
        {
            return velocidadAtaque;
        }

        set
        {
            velocidadAtaque = value;
        }
    }



   
}
