using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardScript : MonoBehaviour {
    private Canvas myCanvas;
	// Use this for initialization
	void Start () {
        myCanvas = GetComponent<Canvas>();
        myCanvas.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        myCanvas.enabled = true;
    }

    void OnTriggerExit2D ()
    {
        myCanvas.enabled = false;
    }
}
