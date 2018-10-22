using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour {

    private List<PocionRoja> pocionesRojas = new List<PocionRoja>();
    private List<PocionAzul> pocionesAzules = new List<PocionAzul>();

    // Use this for initialization
    void Start() {
        Debug.Log("hola mundo inventario");

    }

    // Update is called once per frame
    void Update() {

    }

    public void recibirObjeto(Collider2D obj)
    {
        switch (obj.tag)
        {
           
            case "pocionRoja":
                
                break;


            default:
                break;
        }
    }

}
