using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint_Script : MonoBehaviour {

    public GameObject add_hint_button;
    public GameObject hint_cooldown;
    public GameObject hint_object;
    public GameObject text_object;
    Animator hint_animator;
    Animator text_animator;
    public static float hint_time = 5f;
    public static bool hint_display = false;
    public static bool hint_cooldown_image = false;
    public static bool hint_cooldown_time = false;

    int coin;
    int gem;

    void Start () {
        text_animator = text_object.GetComponent<Animator>();
        hint_animator = hint_object.GetComponent<Animator>();
        hint_animator.SetTrigger("Idle");
        hint_cooldown.SetActive(false);
        add_hint_button.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        if(hint_display == true)
        {
            text_animator.SetTrigger("Exit");
            //hint_object.SetActive(true);
            //text_object.SetActive(false);
            hint_time -= Time.deltaTime;
            hint_cooldown_time = true;
            if (hint_time <= 0)
            {
                hint_animator.SetTrigger("Exit");
                //hint_object.SetActive(false);
                //text_object.SetActive(true);
                hint_display = false;
                hint_time = 5f;
                hint_cooldown_time = false;
            }
        }
        else
        {
            text_animator.SetTrigger("Entrance");
            //hint_object.SetActive(false);
            //text_object.SetActive(true);
        }

        coin = PlayerPrefs.GetInt("Coin");
        gem = PlayerPrefs.GetInt("Gem");

        if (Hint_text.total_hint <= 0)
        {
            add_hint_button.SetActive(true);
        }
    }

    public void hint_click()
    {
        if(Hint_text.total_hint >= 1)
        {
            hint_animator.SetTrigger("Entrance");
            hint_cooldown.SetActive(true);
            Hint_text.total_hint -= 1;
            hint_display = true;
            hint_cooldown_image = true;


        }
        
    }
}
