using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    private Animator myAnimator;
    public float speed;

	// Use this for initialization
	void Start () {

        myAnimator = GetComponent<Animator>();


		
	}
	
	// Update is called once per frame
	void Update () {

        

        // Movement
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0f, 0f));
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0f));
        }
        //End movement

        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        float walkSpeed = 0;

        if (moveHorizontal != 0 || moveVertical != 0)
        {
            walkSpeed = 1;
        }
        myAnimator.SetFloat("speed", walkSpeed);

        if (moveHorizontal != 0 || moveVertical != 0)
        {
            if (moveHorizontal > 0.5)
            {
                transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            }
            else
            {
                transform.localScale = new Vector3(-1.5f, 1.5f, 1.5f);
            }
        }
    }
}
