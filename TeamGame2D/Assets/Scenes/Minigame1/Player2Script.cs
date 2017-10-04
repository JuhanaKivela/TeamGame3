using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Script : MonoBehaviour {

    static Animator anim;
    public float speed;

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0f));

            if (transform.localPosition.y < -20 )
            {
                transform.localPosition = new Vector3(transform.localPosition.x, -20, transform.localPosition.z);
            }

            if (transform.localPosition.y > 12)
            {
                transform.localPosition = new Vector3(transform.localPosition.x, 12, transform.localPosition.z);
            }
        }

        var projectile = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        projectile.transform.position = new Vector3(-5, 0, 0);



    }
}
