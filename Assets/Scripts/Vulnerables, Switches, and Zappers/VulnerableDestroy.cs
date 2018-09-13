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
        if (!h.Zapped)
            shield = shield - 1;

        if (shield <= 0)
        {
            Destroy(d);
            Destroy(gameObject);
        }
    }
}
