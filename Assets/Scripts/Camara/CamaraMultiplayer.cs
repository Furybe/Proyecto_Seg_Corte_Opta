﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMultiplayer : MonoBehaviour {

    public Transform playerTransform;
    public int depth = -20;

    // Update is called once per frame
    void Update()
    {
        if (playerTransform != null)
        {
            transform.position = playerTransform.position + new Vector3(0, 15, depth);
        }
    }
    public void setTarget(Transform target)
    {
        playerTransform = target;
    }

}
