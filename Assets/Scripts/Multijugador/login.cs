using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class web : MonoBehaviour {

    [SerializeField]
    private InputField usuario;

    [SerializeField]
    private InputField contraseña;

    // Use this for initialization
    void Start() {

        StartCoroutine(GetText());

    }

    // Update is called once per frame
    void Update() {


    }

    IEnumerator GetText()
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
}
