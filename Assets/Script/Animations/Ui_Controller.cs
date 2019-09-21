using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ui_Controller : MonoBehaviour {

    public float start;
    public float deduction;
    public GameObject next_stage_bot;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    // Use this for initialization
    void Start()
    {
        star1.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);
        next_stage_bot.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if(CountDownTimer.total_star == 3)
        {
            three_star();
        }
        else if (CountDownTimer.total_star == 2)
        {
            two_star();
        }
        else
        {
            one_star();
        }
    }



    void three_star()
    {
        CountDownTimer.startime = 300f;
        start -= deduction * Time.deltaTime;
        if (start <= 4f && start >= 3f)
        {
            star1.SetActive(true);
        }

        if (start <= 3f && start >= 2f)
        {
            star2.SetActive(true);
        }

        if (start <= 2f  && start >= 1f)
        {
            star3.SetActive(true);
        }

        if(start <= 0)
        {
            next_stage_bot.SetActive(true);
            Time.timeScale = 0f;
        }


    }

    void two_star()
    {
        CountDownTimer.startime = 300f;
        start -= deduction * Time.deltaTime;
        if (start <= 4f && start >= 3f)
        {
            star1.SetActive(true);
        }

        if (start <= 3f && start >= 2f)
        {
            star2.SetActive(true);
        }

        if (start <= 2f && start >= 1f)
        {
            next_stage_bot.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    void one_star()
    {
        CountDownTimer.startime = 300f;
        start -= deduction * Time.deltaTime;
        if (start <= 4f && start >= 3f)
        {
            star1.SetActive(true);
        }

        if (start <= 3f && start >= 2f)
        {
            next_stage_bot.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
