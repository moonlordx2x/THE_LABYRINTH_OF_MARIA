using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Generate_Survival : MonoBehaviour {


    public GameObject loading;
    float timer = 0.20f;
    float timer_2nd = 6f;
    public GameObject image;
    public GameObject loading_menu;
    public GameObject text;


    Animator animator;
    Image image_clip;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        image_clip = loading.GetComponent<Image>();
        animator = image.GetComponent<Animator>();
        animator.SetTrigger("Idle");
        image_clip.fillAmount += timer * Time.deltaTime;
        if (image_clip.fillAmount >= 1)
        {

            loading.SetActive(false);
            text.SetActive(false);
            animator.ResetTrigger("Idle");
            animator.SetTrigger("Animations");
        }

        timer_2nd -= Time.deltaTime;
        if (timer_2nd <= 0)
        {
            image.SetActive(false);
            loading_menu.SetActive(false);
        }

    }
}
