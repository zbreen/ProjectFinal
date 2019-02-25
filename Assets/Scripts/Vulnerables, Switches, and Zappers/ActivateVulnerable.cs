using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateVulnerable : MonoBehaviour {
    public Elevator el;
    public HackerMove hack;
	// Use this for initialization
	void Start () {
        hack = GameObject.Find("HackerBody").GetComponent<HackerMove>();
        el = GameObject.Find("Elevator").GetComponent<Elevator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if (!hack.Zapped)
        {
            //Start elevator's movement
            el.motion = true;
            Destroy(gameObject);
        }
    }
}
