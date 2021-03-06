﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour {


    //atributos - propiedades

    //atributo identificador de jugador
    private int id;
    //atributo para controlar la salud del jugador
    private float salud;
    //permite controlar el estado del jugador (vivo, muerto, etc)
    private string estado;

<<<<<<< HEAD
<<<<<<< HEAD
    //permite llevar la puntuacion del jugador
    private Puntuacion puntos;
=======
>>>>>>> a39e30a6abd790e471fbf9fdb76aafa7165093ea
=======
>>>>>>> a39e30a6abd790e471fbf9fdb76aafa7165093ea

    private Personaje personaje;

    //atributo que controla el daño que puede hacer el jugador
    private float poder;
    //atributo para controlar la velocidad maxima de movimiento
    private float velocidadMovimiento = 100f;
    //atroibuto para controlar la velocidad de ataque del personaje
    private float velocidadAtaque;

    //materiales para construcción
    private int madera;
    private int piedra;
    private int metal;

    //textos para cantidad de materiales
    [SerializeField]
    private Text textoMadera;

    [SerializeField]
    private Text textoPiedra;

    [SerializeField]
    private Text textoMetal;

    //atributo para controlar cuando existen collisiones con las paredes e items
    private bool tocandoPared = false;
    private bool tocandoItem = false;

    //rigid body
    private Rigidbody2D rb;

    //variable para controlar las animaciones del game object
    private Animator anim;



    // Use this for initialization
    void Start()
    {
        //inicializando propiedades 
        this.estado = "vivo";
        this.salud = 100;

        this.madera = 0;
        this.metal = 0;
        this.piedra = 0;

        //inicializando textos
        this.textoMadera.text = madera.ToString();
        this.textoMetal.text = metal.ToString();
        this.textoPiedra.text = piedra.ToString();

        //inicializando el rigidbbody
        rb = GetComponent<Rigidbody2D>();

        //inicializando el animator
        anim = GetComponent<Animator>();


    }

    // Update is called once per frame


    void FixedUpdate()
    {
        //actualizar texto materiales
        actualizarTextoMateriales();

        //comprobamos si el jugador está vivo
        comprobarVidaJugador();

        //permite cambiar la direccion hacia la cual està mirando el personaje
        actualizarDireccionSprite();

        //mantener velocidad máxima
        if (rb.velocity.magnitude > 100f)
        {
            rb.velocity = rb.velocity.normalized * 100f;
        }

        //animaciones 

        //lanzando animacion correr
        anim.SetFloat("velocidad", Mathf.Abs(rb.velocity.x));

        //lanzando animaciòn saltar
        anim.SetFloat("velocidadVertical", Mathf.Abs(rb.velocity.y));

        //lanzando animacion morir
        anim.SetFloat("salud", salud);

        //variable que toma los inputs horizontales "S", "W" o las flechas derecha, izquierda
        float moveHorizontal = Input.GetAxis("Horizontal");

        //vector de velocidad
        Vector2 movimiento = new Vector2(moveHorizontal, 0);

        //agregando el movimiento 
        rb.AddForce(movimiento * velocidadMovimiento);


        //condicion para cuando el jugardor presione la tecla "space"
        if (Input.GetKeyDown("space"))
        {
            //se ejecuta la funciòn saltar
            saltar();
            
        }

        //condicional para iniciar estado farmear
        if (Input.GetKey(KeyCode.L))
        {
            //se ejecuta la funcion recoger- tirar
            farmear();
        }

        //condicional para salir del estado de farmeo
        if (Input.GetKeyUp(KeyCode.L))
        {
            //se ejecuta la funcion recoger- tirar
            pararFarmear();
        }


    }

    //funcion de salto
    void saltar() {

        //se comprueba si se está tocando pared, para cuando esté en aire no haga doble salto
        if (tocandoPared)
        {
            Vector2 salto = new Vector2(0, 35);
            rb.AddForce(salto * velocidadMovimiento);
        }

    }

    //función de recoger - tirar items (por implementar)
    public void farmear() {

        anim.SetBool("atacando", true);
        this.estado = "farmeando";
    }

    public void pararFarmear()
    {
        anim.SetBool("atacando", false);
        this.estado = "vivo";
    }

    //actualizarTextoMateriales
    void actualizarTextoMateriales()
    {
        this.textoMadera.text = madera.ToString();
        this.textoMetal.text = metal.ToString();
        this.textoPiedra.text = piedra.ToString();
    }

    //funcion actualizar dirección sprite
    public void actualizarDireccionSprite() {

        //actualizar dirección del sprite si se está moviendo hacia la derecha
        if (rb.velocity.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);

        }

        // cambiar dirección del sprite si se está moviendo hacia la izquierda
        if (rb.velocity.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);

        }
    }

    //funcion para obtener recursos

    //funcion para detectar collisiones
    private void OnCollisionStay2D(Collision2D collision)
    {
        this.tocandoPared = true;
    }

    //funcion para detectar cuando se sale se las collisions
    private void OnCollisionExit2D(Collision2D collision)
    {
        this.tocandoPared = false;
    }

    //metodo para aplicar daño si el jugador está dentro de la zona


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "zona")
        {
            //se ejecuta metodo para bajar la vida
            recibirDaño(0.1f);

           
        }

    }

    public void recibirDaño(float daño)
    {
        Debug.Log(salud);
        this.Salud = this.salud - daño;

    }

    public void recibirDañoJugador()
    {

    }

    public void comprobarVidaJugador()
    {
        if (this.salud <= 0)
        {
            this.estado = "muerto";
            //puntos.puntuacion();
        }
    }

    //metodo para recibir materiales de los recursos
    public void recibirMaterial(string tipoMaterial, int cantidad)
    {
        switch (tipoMaterial)
        {
            case "piedra":
                this.piedra = this.piedra + cantidad;
                break;

            case "madera":
                this.madera = this.madera + cantidad;
                break;

            case "metal":
                this.metal = this.metal + cantidad;
                break;
            default:
                break;
        }
    }

    //metodo para recibir materiales de los recursos
    public void recibirMaterial(string tipoMaterial, int cantidad)
    {
        switch (tipoMaterial)
        {
            case "piedra":
                this.piedra = this.piedra + cantidad;
                break;

            case "madera":
                this.madera = this.madera + cantidad;
                break;

            case "metal":
                this.metal = this.metal + cantidad;
                break;
            default:
                break;
        }
    }

    //getters y setters de las propiedades

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

    public float Salud
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

    public int Madera
    {
        get
        {
            return madera;
        }

        set
        {
            madera = value;
        }
    }

    public int Piedra
    {
        get
        {
            return piedra;
        }

        set
        {
            piedra = value;
        }
    }

    public int Metal
    {
        get
        {
            return metal;
        }

        set
        {
            metal = value;
        }
    }
}
