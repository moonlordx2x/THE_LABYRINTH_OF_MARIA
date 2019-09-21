using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_Object : MonoBehaviour {


    public Rigidbody2D rb;
    public int Gravity_speed;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player_Tag")
        {
            Physics2D.gravity = new Vector2(0, Gravity_speed);
            rb.isKinematic = false;
        }
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player_Tag")
        {
            Destroy(gameObject);
        }

        else if (col.gameObject.tag == "Platform")
        {
            Destroy(gameObject);
        }
    }
}
