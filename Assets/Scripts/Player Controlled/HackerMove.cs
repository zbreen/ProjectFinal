using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackerMove : MonoBehaviour {
    //Control Hacker Object with mouse
    Vector3 movement;
    int floorMask;
    public float camLength = 1000000000f;
    public Plane ground;
    public bool Zapped;

	// Use this for initialization
	void Start () {
        Vector3 temp=new Vector3(0f,1.5f,0f);
        transform.position = temp;

        //Where mouse object will show up
        floorMask = LayerMask.GetMask("CatchCursor");

        //This is used to make it so an object can or can't be hacked
        Zapped = false;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Ray m = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit floorHit;
        
        if (Physics.Raycast(m, out floorHit, camLength, floorMask))
        {
            //Adjust mouse object's position

            transform.position = floorHit.point;

        }
	}
}
