using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    private Animator myAnimator;
    public float speed = 30;
    private bool attack;

	// Use this for initialization
	void Start () {
        // Gets Animator component. "myAnimator" can be called later on
        myAnimator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

        // Puts Horizontal and vertical movement to a variables. Shortents the code. 
        // Variable can be called instead of Input.GetAxisRaw("");
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        float walkSpeed = 0;

        // Movement
        if (moveHorizontal > 0.5f || moveHorizontal < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0f, 0f));
        }
        if (moveVertical > 0.5f || moveVertical < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0f));
        }
        //End movement

        if (Input.GetAxisRaw("Fire1") > 0.5f && moveHorizontal == 0 && moveVertical == 0)
        {
            attack = true;
        }
        else
        {
            attack = false;
        }
        myAnimator.SetBool("attack", attack);
        

        

        if (moveHorizontal != 0 || moveVertical != 0)
        {
            walkSpeed = 1;
        }
        myAnimator.SetFloat("speed", walkSpeed);

        if (moveHorizontal != 0 )
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