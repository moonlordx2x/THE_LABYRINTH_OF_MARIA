using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour {

    public GameObject Success;
    public GameObject Game_over;
    public GameObject hidden_object;
    public GameObject hint_button;
    public GameObject hint_text;
    public GameObject hint_cooldown;
    public GameObject text_object;
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject object4;
    public GameObject pause_menu;
    public GameObject coin_gem;
    public static float startime;
    public static bool startime_checker;
    public static int total_star = 0;
    public Text text;
    public string db_playerpref;
    public string star_playerpref;
    // Use this for initialization
    void Start () {
        Time.timeScale = 1f;
        startime = 179f;
        startime_checker = false;
        Game_over.SetActive(false);
        Success.SetActive(false);
        StartCoundownTimer();
        coin_gem.SetActive(true);
    }
    
    void StartCoundownTimer()
    {
        if (text != null)
        {
            text.text = "Time Left: 20:00:000";
            InvokeRepeating("UpdateTimer", 0.0f, 0.01667f);
        }
    }


    void UpdateTimer()
    {
        if (text != null && startime_checker == true)
        {
            startime -= Time.deltaTime;
            string minutes = Mathf.Floor(startime / 60).ToString("00");
            string seconds = (startime % 60).ToString("00");
            text.text = minutes + ":" + seconds;
        }
        else
        {
            text.text = "03:00";
        }
    }
   
    // Update is called once per frame
    void Update () {
        int player_int = PlayerPrefs.GetInt(star_playerpref);
        string player_string = PlayerPrefs.GetString(db_playerpref);

        if (Click_Event.object_found == 10)
        {
            int coin = PlayerPrefs.GetInt("Coin");
         
            Success.SetActive(true);
            coin_gem.SetActive(false);
            Game_over.SetActive(false);
            hidden_object.SetActive(false);
            hint_button.SetActive(false);
            hint_text.SetActive(false);
            hint_cooldown.SetActive(false);
            text_object.SetActive(false);
            object1.SetActive(false);
            object2.SetActive(false);
            object3.SetActive(false);
            object4.SetActive(false);
            pause_menu.SetActive(false);
            startime_checker = false;
            if (startime >= 121f && startime <= 179f)
            {
                Debug.Log("Below 3 minutes");
                total_star = 3;
                if (player_int >= 0 && player_int <= 3)
                {
                    PlayerPrefs.SetInt(star_playerpref, 3);
                    PlayerPrefs.SetString(db_playerpref, "Completed");

                    coin += 15;
                    PlayerPrefs.SetInt("Coin", coin);

                }
            }

            else if (startime >= 61f && startime <= 120f)
            {
                Debug.Log("Below 2 minutes");
                total_star = 2;
                if (player_int >= 0 && player_int <= 2)
                {
                    PlayerPrefs.SetInt(star_playerpref, 2);
                    PlayerPrefs.SetString(db_playerpref, "Completed");

                    coin += 10;
                    PlayerPrefs.SetInt("Coin", coin);
                }
            }

            else if (startime <= 60f && startime >= 2f)
            {
                Debug.Log("Below 1 minutes");
                total_star = 1;
                if (player_int >= 0 && player_int <= 1)
                {
                    PlayerPrefs.SetInt(star_playerpref, 1);
                    PlayerPrefs.SetString(db_playerpref, "Completed");

                    coin += 5;
                    PlayerPrefs.SetInt("Coin", coin);
                }
            }
        }
      


        if (text.text == "00:00" || startime <=0)
        {
            startime_checker = false;
            Game_over.SetActive(true);
            coin_gem.SetActive(false);
            hidden_object.SetActive(false);
            hint_button.SetActive(false);
            hint_text.SetActive(false);
            hint_cooldown.SetActive(false);
            text_object.SetActive(false);
            object1.SetActive(false);
            object2.SetActive(false);
            object3.SetActive(false);
            object4.SetActive(false);
            pause_menu.SetActive(false);

            if (player_string != "Completed")
            {
                total_star = 0;
                PlayerPrefs.SetInt(star_playerpref, 0);
                PlayerPrefs.SetString(db_playerpref, "inCompleted");
            }
            Time.timeScale = 0f;
        }
	}
}
