using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VulnerableDestroy : MonoBehaviour {

    int shield = 3;
    public GameObject d;
    public HackerMove h;

	// Use this for initialization
	void Start () {
        h = GameObject.Find("HackerBody").GetComponent<HackerMove>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        //Hack/Destroy the object
        if (!h.Zapped)
            shield = shield - 1;

        if (shield <= 0)
        {
            //This is where the object the vulnerable is attached to is destroyed
            Destroy(d);
            //And this is where the vulnerable itself is destroyed
            Destroy(gameObject);
        }
    }
}
