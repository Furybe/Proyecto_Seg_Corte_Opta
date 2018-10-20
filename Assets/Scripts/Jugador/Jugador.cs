using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {


    //atributos - propiedades

    //atributo identificador de jugador
    private int id;

    //atributo para controlar la salud del jugador
    private float salud;

    //permite controlar el estado del jugador (vivo, muerto, etc)
    private string estado;


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


        //inicializando el rigidbbody
        rb = GetComponent<Rigidbody2D>();

        //inicializando el animator
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame


    void FixedUpdate()
    {
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

        //condicional para capturar cuando se oprime la tecla "L"
        if (Input.GetKeyDown(KeyCode.L))
        {
            //se ejecuta la funcion recoger- tirar
            recogerTirar();
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
    public void recogerTirar() {

        anim.SetBool("atacando", true);
        this.estado = "farmeando";
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

            Debug.Log("El jugador está dentro de la zona AAAAAAAAAAAAAAAAAAAAAA");
        }

    }

    public void recibirDaño(float daño)
    {
        Debug.Log(salud);
        this.Salud = this.salud - daño;

    }

    public void recibirDañoJuador()
    {

    }

    public void comprobarVidaJugador()
    {
        if (this.salud <= 0)
        {
            this.estado = "muerto";
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
