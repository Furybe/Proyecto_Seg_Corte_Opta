using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofreEpico : Cofre {


    //variable para controlar las animaciones del game object
    private Animator anim;



    // Use this for initialization
    void Start () {

        //inicializando el animator
        anim = GetComponent<Animator>();

        this.Nombre = "Cofre Épico";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "jugador")
        {
            anim.SetBool("Abrir", true);
            StartCoroutine(dropConDelay());
          
            

        }

    }

    public IEnumerator dropConDelay()
    {
      
        yield return new WaitForSeconds(1);
        this.dropearItems();
       
    }




}
