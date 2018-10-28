using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour {

    private List<GameObject> pocionesRojas = new List<GameObject>();
    private List<GameObject> pocionesAzules = new List<GameObject>();
    private List<GameObject> pocionesFucsias = new List<GameObject>();

    // Use this for initialization
    void Start() {


    }

    // Update is called once per frame
    void FixedUpdate() {

    }

    public void recibirObjeto(GameObject obj)
    {
        switch (obj.tag)
        {
           
            case "pocionRoja":
                
                pocionesRojas.Add(obj);
                break;

            case "pocionAzul":
                pocionesAzules.Add(obj);
                break;

            case "pocionFucsia":
                pocionesFucsias.Add(obj);
                break;

            default:

                break;
        }
    }

    public void consumirObjeto(string nombreObjeto, int idJugador, Transform posicion, float direccion)
    {
        switch (nombreObjeto)
        {
            case "pocionRoja":
                if (pocionesRojas.Count>0)
                {

                    pocionesRojas[0].GetComponent<PocionRoja>().consumir(idJugador,transform, direccion);
                    pocionesRojas.RemoveAt(0);
                }
                break;

            case "pocionAzul":
                if (pocionesAzules.Count > 0)
                {
                    
                    pocionesAzules[0].GetComponent<PocionAzul>().consumir(idJugador, transform, direccion);
                    pocionesAzules.RemoveAt(0);
                }
                break;

            case "pocionFucsia":
                
                if (pocionesFucsias.Count > 0)
                {
                    Debug.Log("consumida pocion fucsia");
                    pocionesFucsias[0].GetComponent<PocionFucsia>().consumir(idJugador, transform, direccion);
                    pocionesFucsias.RemoveAt(0);
                }
                break;

            default:
                break;
        }
    }

}
