using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    public float speed = 15;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        //Gets player tag. Player can be accessed trough tag
        var player = GameObject.FindWithTag("Player");
        //Puts distance between player and enemy to a variable
        float distance = Vector3.Distance(transform.position, player.transform.position);

        Vector3 locationBetween = player.transform.position - transform.position;
        
        float MinDistance = 10;

        if (distance<50)
        {


            if (locationBetween.x > 1)
            {
                transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                if (locationBetween.x > MinDistance)
                {
                    transform.Translate(new Vector3(1 * speed * Time.deltaTime, 0f, 0f));
                }
            }
            else if (locationBetween.x < -1)
            {
                transform.localScale = new Vector3(-1.5f, 1.5f, 1.5f);
                if (locationBetween.x < MinDistance * -1)
                {
                    transform.Translate(new Vector3(-1 * speed * Time.deltaTime, 0f, 0f));
                }
            }
            
            if (locationBetween.y > (MinDistance/5))
            {
                transform.Translate(new Vector3(0f, 1 * speed * Time.deltaTime, 0f));
            }
            else if (locationBetween.y < ((MinDistance*-1)/3))
            {
                transform.Translate(new Vector3(0f, -1 * speed * Time.deltaTime, 0f));
            }
        }

        float attackRange = 10;
        if ((locationBetween.x < attackRange && locationBetween.x > attackRange*-1) && (locationBetween.y < (attackRange/2) && locationBetween.y > (attackRange/2) * -1))
        {

            //Debug.Log("ATTACK");
        }
        else
        {
            
        }
    }
}
