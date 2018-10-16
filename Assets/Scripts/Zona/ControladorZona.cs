using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorZona : MonoBehaviour {

	public RectTransform asd;
	private string timer;
	// Use this for initialization
	void Awake () {
		timer = ""+ Time.timeSinceLevelLoad.ToString("f0");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(timer);
		if (timer == "5" || timer == "20" || timer == "25")
		{
			zona();
		}
	}
	private void zona(){

		asd.transform.localScale = new Vector3(-20f,0,0);
	}
}
