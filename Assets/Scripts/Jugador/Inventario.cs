using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour {

    private List<GameObject> pocionesRojas = new List<GameObject>();
    private List<GameObject> pocionesAzules = new List<GameObject>();

    // Use this for initialization
    void Start() {


    }

    // Update is called once per frame
    void FixedUpdate() {
        Debug.Log(pocionesRojas.Count);
    }

    public void recibirObjeto(GameObject obj)
    {
        switch (obj.tag)
        {
           
            case "pocionRoja":
                Debug.Log("entró");
                pocionesRojas.Add(obj);
                break;

            case "pocionAzul":
                pocionesAzules.Add(obj);
                break;

            default:

                break;
        }
    }

}
