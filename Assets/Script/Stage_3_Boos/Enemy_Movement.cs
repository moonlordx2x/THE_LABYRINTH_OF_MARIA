using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour {

    float werewolf_movement = 20f;
    float step;
    private Transform player_tag;

    public static int movement_direction = 0;
    public static bool Game_Start = false;
    public static bool Player_detect = false;


    // Use this for initialization
    void Start () {

        player_tag = GameObject.FindGameObjectWithTag("Player_Tag").GetComponent<Transform>();
        step = werewolf_movement * Time.deltaTime;
        Player_detect = false;
        Game_Start = false;
        movement_direction = 0;
    }
	
	// Update is called once per frame
	void Update () {

        if(Player_detect == true && movement_direction == 1 && Game_Start == true)
        {
            transform.localScale = new Vector2(-1f, 1f);
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(player_tag.position.x + 50, transform.position.y), werewolf_movement * Time.deltaTime);
        }
        else if (Player_detect == true && movement_direction == 2 && Game_Start == true)
        {
            transform.localScale = new Vector2(1f, 1f);
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(player_tag.position.x - 50, transform.position.y), werewolf_movement * Time.deltaTime);
        }
        else
        {
            
            if (movement_direction == 1 && Player_detect == false && Game_Start == true)
            {
                this.gameObject.transform.position += Vector3.left * step;
                this.gameObject.transform.localScale = new Vector2(-1f, 1f);
            }

            else if (movement_direction == 2 && Player_detect == false && Game_Start == true)
            {
                this.gameObject.transform.position += Vector3.right * step;
                this.gameObject.transform.localScale = new Vector2(1f, 1f);
            }
            else if (movement_direction == 0 && Player_detect == false && Game_Start == false)
            {
                
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Left_Ground")
        {
            movement_direction = 2;
        }
        else if (collision.gameObject.tag == "Right_Ground")
        {
            movement_direction = 1;
        }
    }
    
}
