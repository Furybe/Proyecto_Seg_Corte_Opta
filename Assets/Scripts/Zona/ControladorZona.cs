using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorZona : MonoBehaviour {

	public RectTransform panelIzq;
	public RectTransform panelDer;
	public Animator animIzq;
	public Animator animDer;
	private float tiempo;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tiempo = (int)Time.timeSinceLevelLoad;
		if ((int)Time.timeSinceLevelLoad > 15)
		{
			MoverZona();
		}
	}
	private void MoverZona()
	{
		animIzq.SetBool("MoverZona", true);
		animDer.SetBool("MoverZona", true);
	}
}
