using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack : MonoBehaviour {

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player_Tag")
        {

            int random = Random.Range(1, 4);
            Health_Bar.health_point -= random;
            Health_Bar.Text_point -= random;
        }
    }
}
