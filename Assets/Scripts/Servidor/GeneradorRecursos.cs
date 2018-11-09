using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GeneradorRecursos : NetworkBehaviour{

    [SerializeField]
    GameObject roca;

    [SerializeField]
    private GameObject cuadroMadera;

    [SerializeField]
    private GameObject cuadroPiedra;

    [SerializeField]
    private GameObject cuadroMetal;

    // Use this for initialization
    void Start () {

        //Instantiate the prefab
        GameObject instancia = Instantiate(roca, new Vector3(-5f, -28f, 0), Quaternion.identity);
        //Spawn the GameObject you assign in the Inspector
        NetworkServer.Spawn(instancia);
    }
	
	// Update is called once per frame
	void Update () {
    
     
    }

    [Command]
    public void CmdConstruirBloque(GameObject cuadro, float x, float y )
    {
        GameObject instancia = Instantiate(cuadroMadera, new Vector3(x, y, 0), Quaternion.identity);
        //Spawn the GameObject you assign in the Inspector
        NetworkServer.Spawn(instancia);
    }

    [Command]
     void CmdASD() {
        Vector3 position = new Vector3(Random.Range(-200.0f, 200.0f), 0, Random.Range(-10.0f, 10.0f));
        GameObject instancia = Instantiate(cuadroMadera, position, Quaternion.identity);

        NetworkServer.Spawn(instancia);
    }
}
