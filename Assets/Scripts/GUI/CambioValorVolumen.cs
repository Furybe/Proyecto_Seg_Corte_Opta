using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioValorVolumen : MonoBehaviour {

    //  Referencia al componente Audio Source
    private AudioSource soundtrack;

    // Variable del Volumen de la musica que va ser modificado
    // Por el Slider 
    private float VolumenMusica = 1f;



	// Use this for initialization
	void Start ()
    {
        // Asigan el componente del Audio Source para poder controlarlo
       soundtrack = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update ()
    {
        // Los cambios del volumen del Audio Source siendo igual
        // al VolumenMusica
        soundtrack.volume = VolumenMusica;	
	}

    // Metodo que es llamado para el objeto slider
    // Este metodo toma al volumen como valor que pasa por el slider
    public void EnviarVolumen(float volumen)
    {
        VolumenMusica = volumen;
    }
}
