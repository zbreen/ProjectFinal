using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour {

    float speed = 3f;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    private void FixedUpdate()
    {

    }
    private void OnCollisionStay(Collision collision)
    {
        //Move object like it'd move on a conveyor belt
        collision.transform.position += transform.forward * speed * Time.deltaTime;
    }
}
