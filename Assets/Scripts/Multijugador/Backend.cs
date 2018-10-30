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
    private InputField inputUsuarioRegistro;

    [SerializeField]
    private InputField inputContraseñaRegistro;

    [SerializeField]
    private InputField inputContraseñaRegistroConfirm;

    [SerializeField]
    private InputField inputNombreRegistro;

    [SerializeField]
    private InputField inputCorreoRegistro;

    [SerializeField]
    private InputField inputCorreoRegistroConfirm;

    [SerializeField]
    private Button boton;

    [SerializeField]
    private Button botonR;

    // Use this for initialization
    void Start () {


        Button botonLogin = boton.GetComponent<Button>();
        botonLogin.onClick.AddListener(ingresar);

        Button botonRegistro = botonR.GetComponent<Button>();
        botonRegistro.onClick.AddListener(registro);


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

    IEnumerator registroPost(string usuario, string contraseña, string correo, string nombre)
    {
        WWWForm form = new WWWForm();
        form.AddField("nombre", nombre);
        form.AddField("usuario", usuario);
        form.AddField("contrasena", contraseña);
        form.AddField("pais", "Colombia");
        form.AddField("fecha_registro", "");
        form.AddField("correo", correo);


        UnityWebRequest www = UnityWebRequest.Post("http://localhost:8000/api/usuarios", form);
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
        
        StartCoroutine(loginPost(inputUsuario.text, inputContraseña.text));

    }

    void registro()
    {
        if (inputContraseñaRegistro.text == inputContraseñaRegistroConfirm.text)
        {

            if (inputCorreoRegistro.text == inputCorreoRegistroConfirm.text)
            {
                StartCoroutine(registroPost(inputUsuarioRegistro.text, inputContraseñaRegistro.text, inputCorreoRegistro.text, inputNombreRegistro.text));

            }
        }
       
    }

}
