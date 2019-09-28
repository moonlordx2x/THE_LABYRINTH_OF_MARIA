using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info_Button : MonoBehaviour {


    public Animator animator;
    public GameObject info_setting;


	// Use this for initialization
	void Start () {
        animator.SetTrigger("Idle");
        animator.ResetTrigger("Exit");
        animator.ResetTrigger("Intro");

    }

    public void info_intro()
    {
        info_setting.SetActive(true);
        animator.SetTrigger("Intro");
        animator.ResetTrigger("Exit");
    }


    public void info_exit()
    {
        info_setting.SetActive(true);
        animator.SetTrigger("Exit");
        animator.ResetTrigger("Intro");
    }
}
