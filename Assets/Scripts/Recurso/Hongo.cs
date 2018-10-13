using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hongo : Recurso {

    [SerializeField]
    protected  GameObject [] objetosDropeados = new GameObject[3];
    
    protected int salud = 30;
    
 


	// Use this for initialization
	void Start () {

    
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	 	
	}


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "jugador")
        {
            this.DropearItems();
        }
    }




    public void bajarSalud()
    {
        this.salud = salud - 10;
        if (this.salud==0)
        {
            DropearItems();
        }
    }

    public  void DropearItems()
    {
   

        for (int i = 0; i < this.objetosDropeados.Length; i++)
        {
            Instantiate(this.objetosDropeados[i], transform.position, Quaternion.identity);
        }
        
        Destroy(gameObject);
   
    }




}
