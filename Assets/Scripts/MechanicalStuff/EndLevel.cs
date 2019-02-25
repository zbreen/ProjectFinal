using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour {
    public Text winText;
    public GameObject player;
    public string level;

    BodyMove bodyMove;
	// Use this for initialization
	void Start () {
        winText.text = "";
        //bodyMove = GetComponent<BodyMove>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            winText.text = "You cleared the sector!";
            //disable player movement?
            //bodyMove.enabled = false;
            StartCoroutine(Warp());
        }
    }

    IEnumerator Warp()
    {
        //Move player to next level
        yield return new WaitForSeconds(3);
        winText.text = "";
        
        SceneManager.LoadScene(level);
    }
}
