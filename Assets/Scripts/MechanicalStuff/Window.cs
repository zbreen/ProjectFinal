﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        //Object destructible to weight
        if (collision.gameObject.CompareTag("Weight"))
            Destroy(gameObject);
    }
}
