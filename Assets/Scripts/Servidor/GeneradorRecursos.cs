using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GeneradorRecursos : NetworkBehaviour{

    [SerializeField]
    GameObject roca;
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
}
