using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress_bar_player_location : MonoBehaviour {

    public GameObject ProgressBar;

    Animator animator;




    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player_Tag")
        {
            animator = ProgressBar.GetComponent<Animator>();


            if(this.gameObject.name == "First_Entrance")
            {
                animator.SetTrigger("Entrance_2");
                animator.ResetTrigger("Exit_2");
                Debug.Log(this.gameObject.name);
            }
            else if (this.gameObject.name == "First_Stop")
            {
                animator.SetTrigger("Exit_2");
                animator.ResetTrigger("Entrance_2");
                Debug.Log(this.gameObject.name);
            }
            else if (this.gameObject.name == "Second_Stop")
            {
                animator.SetTrigger("Exit_3");
                animator.ResetTrigger("Entrance_3");
                Debug.Log(this.gameObject.name);
            }
            else if (this.gameObject.name == "Second_Entrance")
            {
                animator.SetTrigger("Entrance_3");
                animator.ResetTrigger("Exit_3");
                Debug.Log(this.gameObject.name);
            }
            else if (this.gameObject.name == "Third_Stop")
            {
                animator.SetTrigger("Exit_4");
                animator.ResetTrigger("Entrance_4");
                Debug.Log(this.gameObject.name);
            }
            else if (this.gameObject.name == "Third_Entrance")
            {
                animator.SetTrigger("Entrance_4");
                animator.ResetTrigger("Exit_4");
                Debug.Log(this.gameObject.name);
            }


        }
    }


}
