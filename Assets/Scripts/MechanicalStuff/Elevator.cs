using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {
    public Transform[] point;
    public bool motion;
    public float speed = 0.4f;
    public GameObject player;

    private int current = 0;

	// Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
    void Update() {
        //Move the platform about
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
    //Attach player to object
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
            player.transform.parent = transform;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
            player.transform.parent = null;
    }
}
