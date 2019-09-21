using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Button : MonoBehaviour {


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Werewolf")
        {
            int random = Random.Range(5, 11);
            Enemy_Health_Bar.health_point -= random;
            Enemy_Health_Bar.Text_point -= random;
        }
    }
}
