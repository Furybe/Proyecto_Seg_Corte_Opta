using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectoSonido : MonoBehaviour {

    AudioSource effectoSonido;
    public bool test = true;

	// Use this for initialization
	void Start ()
    {
        effectoSonido = GetComponent<AudioSource>();
	}

    public void QuitarEffecto()
    {
        if(test==true)
        {
            effectoSonido.Pause();
            test = false;
        }else if(test==false)
        {
            effectoSonido.Play();
            test = true;
        }
    }

    public void Tocar()
    {
        if(test==true)
        {
            effectoSonido.Play();
        }else if(test==false)
        {
            effectoSonido.Pause();
        }
    }
	
}
