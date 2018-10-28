using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour {

    [SerializeField]
    protected GameObject[] objetosDropeados = new GameObject[7];

    private string nombre;

  

    // Use this for initialization
    void Start () {

       

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    protected void dropearItems()
    {

        for (int i = 0; i < this.objetosDropeados.Length; i++)
        {
            Instantiate(this.objetosDropeados[i], transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }




    protected string Nombre
    {
        get
        {
            return nombre;
        }

        set
        {
            nombre = value;
        }
    }

}
