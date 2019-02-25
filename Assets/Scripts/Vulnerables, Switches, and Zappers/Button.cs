using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public Material O; //On
    public Material I; //Off
    public GameObject D;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //This is so we can disable doors/bug zappers
            GetComponent<Renderer>().material = O;
            if (D.activeInHierarchy)
            {
                D.SetActive(false);
            }
            else
            {
                D.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<Renderer>().material = I;
            D.SetActive(true);
        }
        GetComponent<Renderer>().material = I;
        if (D.activeInHierarchy)
        {
            D.SetActive(true);
        }
        else
        {
            D.SetActive(false);
        }
    }
}
