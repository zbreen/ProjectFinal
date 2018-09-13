using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {
    public Transform[] point;
    public bool motion;
    public float speed = 0.4f;

    private int current = 0;

	// Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
    void Update() {
        if (motion == true) { 
            if (transform.position != point[current].position)
            {
                transform.position = Vector3.MoveTowards(transform.position, point[current].position, speed * Time.deltaTime);
            }
            else
            {
                current = (current + 1) % point.Length;
            }
        }
	}
}
