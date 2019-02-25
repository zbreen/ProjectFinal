using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossGuard : MonoBehaviour {
    public int hp;
    public Transform[] point;
    public float speed = 0.2f;
    public GameObject block;

    private int current = 0;
    public GameObject beam;
    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        //Have it move when hit
        if (transform.position != point[current].position && current <= 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, point[current].position, speed * Time.deltaTime);
        }
        else
        //Have it attack
        {
            if (current == 2 && hp == 1)
            {
                beam.SetActive(true); 
                transform.Rotate(Vector3.left * Time.deltaTime, speed - 2.0f);
            }
        }
        //Finish it
        if (hp <= 0)
        {
            Destroy(block);
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Weight"))
        {
            --hp;
            if(current < 2)
                current = current + 1;
            Destroy(collision.gameObject);
        }
    }
}
