using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack : MonoBehaviour {
    int random;
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player_Tag")
        {

            if (Enemy_Health_Bar.Text_point <= 100)
            {
                 random = Random.Range(5, 11);
            }
            else
            {
                 random = Random.Range(1, 4);
            }
            
            Health_Bar.health_point -= random;
            Health_Bar.Text_point -= random;
        }
    }
}
