using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackerMove : MonoBehaviour {

    Vector3 movement;
    int floorMask;
    public float camLength = 1000000000f;
    public Plane ground;
    public bool Zapped;

	// Use this for initialization
	void Start () {
        Vector3 temp=new Vector3(0f,1.5f,0f);
        transform.position = temp;

        floorMask = LayerMask.GetMask("CatchCursor");

        Zapped = false;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Ray m = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit floorHit;
        //Debug.Log(m.direction);
        float amount;
        if (ground.Raycast(m,out amount))
        {
            //Debug.Log("here");
        }
        if (Physics.Raycast(m, out floorHit, camLength, floorMask))
        {
           //Debug.Log(floorHit);

            //Vector3 objectToMouse = floorHit.point - transform.position;
            //objectToMouse.y = 1f;
            //Debug.Log(objectToMouse);

            transform.position = floorHit.point;

        }
        //transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 1.0f, Input.mousePosition.z));
	}
}
