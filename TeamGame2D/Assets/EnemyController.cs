using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public Transform Player;
    int moveSpeed = 15;
    int maxDistance = 20;
    int minDist = 1;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= minDist)
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;


            if (Vector3.Distance(transform.position, Player.position) <= maxDistance)
            {
                
            }
        }
	}
}
