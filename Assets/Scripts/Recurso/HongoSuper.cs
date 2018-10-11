using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HongoSuper : Hongo {


    public GameObject pocionAzul;

    // Use this for inistialization
    void Start () {

        PocionAzul pocionAzul = new PocionAzul();
        this.objectosDropeados.Add(pocionAzul);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public  void DropearItems()
    {
        Debug.Log("dropeado");
        Instantiate(pocionAzul, transform.position, Quaternion.identity   );
         Destroy(gameObject);
    }
}
