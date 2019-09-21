using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player_Controller_Stage_3 : MonoBehaviour {

    private float speed = 50f;
    private float movement = 0f;
    public Animator animate;
    public Rigidbody2D Rigidbody2D;
    public GameObject Revive;


    public static bool player_checker = true;


    // Use this for initialization
    void Start()
    {
        animate = GetComponent<Animator>();
        Revive.SetActive(false);
        player_checker = true;
    }

    // Update is called once per frame
    void Update()
    {
   
        if (player_checker == true)
        {
            Player_movement();
        }
        else
        {
            Player_Disabled();
        }


        if (movement < 0 || Input.GetKey("a"))
        {
            transform.localScale = new Vector2(-1f, 1f);
            animate.SetTrigger("Running");
            animate.ResetTrigger("Idle");

        }
        else if (movement > 0 || Input.GetKey("d"))
        {
            transform.localScale = new Vector2(1f, 1f);
            animate.SetTrigger("Running");
            animate.ResetTrigger("Idle");
 
        }
        else if (CrossPlatformInputManager.GetButtonDown("Fire1"))
        {
            animate.SetTrigger("Attack");
            animate.ResetTrigger("Running");
            animate.ResetTrigger("Idle");
        }
        else
        {

            Rigidbody2D.velocity = new Vector2(0, Rigidbody2D.velocity.y);
            animate.SetTrigger("Idle");
            animate.ResetTrigger("Running");
        }

    }

    void Player_movement()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        movement = CrossPlatformInputManager.GetAxis("Horizontal");
        speed = 50f;
        Rigidbody2D.velocity = new Vector2(speed * movement, Rigidbody2D.velocity.y);
    }

    void Player_Disabled()
    {
        movement = 0;
        speed = 0f;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Falling_Object")
        {
            Revive.SetActive(true);
            //Time.timeScale = 0f;
            player_checker = false;
        }
    }
}
