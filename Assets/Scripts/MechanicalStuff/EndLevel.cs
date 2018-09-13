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
        yield return new WaitForSeconds(3);
        winText.text = "";
        // Vector3 next = nextLevel.transform.position;
        //premake a vector3, set equal to next
        //player.transform.SetPositionAndRotation(nextLevel.transform.position, nextLevel.transform.rotation);
        //bodyMove.enabled = true;
        //player.transform.position = next;
        SceneManager.LoadScene(level);
    }
}
