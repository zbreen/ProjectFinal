using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugZap : MonoBehaviour {

    public HackerMove p;

	// Use this for initialization
	void Start () {
        p = GameObject.Find("HackerBody").GetComponent<HackerMove>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hacker"))
        {
            p.Zapped = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Hacker"))
        {
            p.Zapped = false;
        }
        p.Zapped = false;
    }
}
