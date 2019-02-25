using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

    public BodyMove intruder;
	// Use this for initialization
	void Start () {
        intruder = GameObject.Find("MainBody").GetComponent<BodyMove>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        //Use this to eliminate player
        if (other.gameObject.CompareTag("Player"))
        {
            intruder.Die();
        }
    }
}
