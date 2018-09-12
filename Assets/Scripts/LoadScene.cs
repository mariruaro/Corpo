using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public GameObject spawnPoint;
    public GameObject spawnZero;
    public GameObject spawnOne;
    public GameObject spawnTwo;
    public GameObject spawnThree;
    private bool touch = false;
    
    public GameObject player;
    
	// Use this for initialization
	void Start () {
        Debug.Log(spawnPoint);
        if (touch)
        {
            player.transform.SetPositionAndRotation(spawnPoint.transform.position, spawnPoint.transform.rotation);
        }

    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(spawnPoint);
        if (touch)
        {
            player.transform.SetPositionAndRotation(spawnPoint.transform.position, spawnPoint.transform.rotation);
        }

    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Portal1")
        {
            spawnPoint = spawnOne;
            touch = true;
            SceneManager.LoadScene("Video1");
        }

        if (hit.gameObject.tag == "Portal2")
        {
            spawnPoint = spawnTwo;
            touch = true;
            SceneManager.LoadScene("Video2");
        }

        if (hit.gameObject.tag == "Portal3")
        {
            spawnPoint = spawnThree;
            touch = true;
            SceneManager.LoadScene("Video3");
        }
    }
}
