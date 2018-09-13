using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour {
    public float a;
    public float speed = 0.5f;
    private Vector3 begin;
    // Use this for initialization
    void Start () {
        begin = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 v = begin;
        v.x += a * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
