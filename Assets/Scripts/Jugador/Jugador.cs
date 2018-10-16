using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {


    //atributos - propiedades

    //atributo identificador de jugador
    private int id;

    //atributo para controlar la salud del jugador
    private int salud;
    
    //permite controlar el estado del jugador (vivo, muerto, etc)
    private string estado;

    
    private Personaje personaje;

    //atributo que controla el daño que puede hacer el jugador
    private float poder;

    //atributo para controlar la velocidad maxima de movimiento
    private float velocidadMovimiento = 100f;
    
    //atroibuto para controlar la velocidad de ataque del personaje
    private float velocidadAtaque;

    //atributo para controlar cuando existen collisiones con las paredes e items
    private bool tocandoPared = false;
    private bool tocandoItem = false;

   
    private Rigidbody2D rb;

    //variable para controlar las animaciones del game object
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        //inicializando el rigidbbody
        rb = GetComponent<Rigidbody2D>();

        //inicializando el animator
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame


    void FixedUpdate()
    {
        //permite cambiar la direccion hacia la cual està mirando el personaje
        actualizarDireccionSprite();

        //mantener velocidad máxima
        if (rb.velocity.magnitude > 100f)
        {
            rb.velocity = rb.velocity.normalized * 100f;
        }

        //lanzando animacion correr
        anim.SetFloat("velocidad", Mathf.Abs(rb.velocity.x));
        
        //lanzando animaciòn saltar
        anim.SetFloat("velocidadVertical", Mathf.Abs(rb.velocity.y));

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

    }

    
    //funcion actualizar dirección sprite
    public void actualizarDireccionSprite(){

        //actualizar dirección del sprite si se está moviendo hacia la derecha
        if (rb.velocity.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);

        }

        // cambiar dirección del sprite si se está moviendo hacia la izquierda
        if(rb.velocity.x < 0)
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
