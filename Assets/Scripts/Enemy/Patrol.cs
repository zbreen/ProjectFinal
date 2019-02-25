using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {
    public Transform[] point;
    public float speed = 0.2f;

    private int current = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Move enemy around from point to point
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
