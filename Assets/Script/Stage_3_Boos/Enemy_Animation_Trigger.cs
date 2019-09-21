using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Animation_Trigger : MonoBehaviour {

    public Animator enemyanimation;
    float attack_seconds;
    bool attack_checker;
    void Start () {
        if (Enemy_Health_Bar.Text_point <= 100)
        {
            attack_seconds = 0.7f;
        }
        else
        {
            attack_seconds = 1.0f;
        }
        attack_checker = false;
    }
	
	// Update is called once per frame
	void Update () {
		if(Enemy_Movement.Player_detect == false && Enemy_Movement.Game_Start == true)
        {

            if (Enemy_Health_Bar.Text_point <= 100)
            {
                enemyanimation.SetTrigger("RUNNING_2");
            }
            else
            {
                enemyanimation.SetTrigger("RUNNING");
            }
        }
        else if (Enemy_Movement.Game_Start == false)
        {
            if (Enemy_Health_Bar.Text_point <= 100)
            {
                enemyanimation.SetTrigger("IDLE_2");
            }
            else
            {
                enemyanimation.SetTrigger("IDLE");
            }
            
        }

        if (attack_checker == true) {
            attack_seconds -= Time.deltaTime;
            Enemy_Movement.Game_Start = false;
            if (attack_seconds <= 0)
            {
                attack_checker = false;
                if (Enemy_Health_Bar.Text_point <= 100)
                {
                    attack_seconds = 0.7f;
                }
                else
                {
                    attack_seconds = 1.0f;
                }
                
                Enemy_Movement.Game_Start = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player_Tag")
        {
            Enemy_Movement.Player_detect = true;

            if(attack_checker == false)
            {

                if (Enemy_Health_Bar.Text_point <= 100)
                {
                    enemyanimation.SetTrigger("ATTACK_2");
                }
                else
                {
                    enemyanimation.SetTrigger("ATTACK");
                }
                attack_checker = true;
            }
            
        }
        else if (collision.gameObject.tag == "Main_Player")
        {
            Enemy_Movement.Game_Start = true;
            if(Enemy_Movement.movement_direction == 0)
            {
                Enemy_Movement.movement_direction = 1;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player_Tag")
        {
            Enemy_Movement.Player_detect = false;

            if (Enemy_Health_Bar.Text_point <= 100)
            {
                enemyanimation.ResetTrigger("ATTACK_2");
            }
            else
            {
                enemyanimation.ResetTrigger("ATTACK");
            }
        }
    }
}
