using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BodyMove : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
    Vector3 movement;
    public GameObject p;
    public bool alive;
    public int level = 1;
    public string checkpoint;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody> ();
        alive = true;
        p = GetComponent<GameObject>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Move(h, v);

        if (Input.GetKey("escape"))
            Application.Quit();
    }

    /*
     void placebo(){
         bool goodgame = true;
     }
     */

    void Move(float h, float v)
    {
        movement.Set(h, 0f, v);
        movement = movement.normalized * speed * Time.deltaTime;

        rb.MovePosition(transform.position + movement);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pit") || collision.gameObject.CompareTag("Guard"))
        {
            Die();
        }

        else if (collision.gameObject.CompareTag("Elevator"))
        {
            transform.parent = collision.gameObject.transform;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        transform.parent = null;
    }

    public void Die()
    {
        alive = false;
        SceneManager.LoadScene(checkpoint);
    }

    
}
