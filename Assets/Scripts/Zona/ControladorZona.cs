using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorZona : MonoBehaviour {

	public Transform panelDer;
	public Transform panelIzq;
	private float t;
	private Vector3 posInicialD;
	private Vector3 objetivoD = new Vector3(20f,0f,0f);
	private Vector3 posInicialI;
	private Vector3 objetivoI = new Vector3(5f,0f,0f);
	private float tiempoParaAlcanzarObjetivo = 500f;

    // Use this for initialization
    void Start () {
		posInicialD = panelDer.transform.position;
		posInicialI = panelIzq.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		t += Time.deltaTime / tiempoParaAlcanzarObjetivo;
		panelDer.transform.position = Vector3.Lerp(posInicialD, objetivoD, t);
		panelIzq.transform.position = Vector3.Lerp(posInicialI, objetivoI, t);
	}
}
