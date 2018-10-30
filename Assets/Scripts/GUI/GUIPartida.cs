using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIPartida : MonoBehaviour {



    [SerializeField]
    private Button boton;


    // Use this for initialization
    void Start () {

        Button botonIniciarPartida = boton.GetComponent<Button>();
        botonIniciarPartida.onClick.AddListener(iniciar);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void iniciar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Multijugador");
    }
}
