using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Recurso : NetworkBehaviour
{

    protected string nombreMaterial;
    protected int cantidadMaterial;

   

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void FixedUpdate()
    {
       
    }

 
    public void DestruirRecurso()
    {
        Destroy(this.gameObject);
    }



    //método dropear material

   protected int DropearMaterial()
    {
        if (this.cantidadMaterial > 0)
        {
            this.cantidadMaterial--;

            return 1;
        }

        return 0;
    }

    
    protected void comprobarDestruirRecurso()
    {
        if (this.cantidadMaterial <= 0)
        {

            //this.DestruirRecurso();

            CmdDestroy();
        }
    }

    [Command]
    void CmdDestroy()
    {
        NetworkBehaviour.Destroy(this.gameObject);
    }
}
