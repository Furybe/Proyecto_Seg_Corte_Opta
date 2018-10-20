using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Backend : MonoBehaviour {


    [SerializeField]
    private InputField inputUsuario;

    [SerializeField]
    private InputField inputContraseña;

    [SerializeField]
    private Button boton;

    // Use this for initialization
    void Start () {

        //StartCoroutine(loginPost("junini", "djasljsidoajdioj"));
        Button botonLogin = boton.GetComponent<Button>();
        botonLogin.onClick.AddListener(ingresar);
    }
	
	// Update is called once per frame
	void Update () {

       
    }

    IEnumerator loginGet(string usuario, string contraseña)
    {

        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost:8000/api/usuarios"))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                // Show results as text
                Debug.Log(www.downloadHandler.text);

                // Or retrieve results as binary data
                byte[] results = www.downloadHandler.data;
            }
        }

    }

    IEnumerator loginPost(string usuario, string contraseña)
    {
             WWWForm form = new WWWForm();
             form.AddField("usuario",usuario);
             form.AddField("contrasena",contraseña);

      
            UnityWebRequest www = UnityWebRequest.Post("http://localhost:8000/api/login", form);
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Form upload complete!");
                UnityEngine.SceneManagement.SceneManager.LoadScene("Inicio");

        }
    }

    void ingresar()
    {
        Debug.Log("xd");
        StartCoroutine(loginPost(inputUsuario.text, inputContraseña.text));

    }

}
