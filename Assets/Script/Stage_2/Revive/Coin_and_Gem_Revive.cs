using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin_and_Gem_Revive : MonoBehaviour {

    public GameObject revive_menu;
    public GameObject Game_over_menu;

    public GameObject coin_object;
    public GameObject gem_object;

    Text coin_text;
    Text gem_text;

    int coin;
    int gem;
    // Use this for initialization
    void Start () {
        //revive_menu.SetActive(false);
        Game_over_menu.SetActive(false);

    }

    void Update()
    {
        coin = PlayerPrefs.GetInt("Coin");
        gem = PlayerPrefs.GetInt("Gem");
        coin_text = GameObject.FindGameObjectWithTag("Coin_Text").GetComponent<Text>();
        gem_text = GameObject.FindGameObjectWithTag("Gem_Text").GetComponent<Text>();

        if (coin <=0 && gem <= 0)
        {
            revive_menu.SetActive(false);
            Game_over_menu.SetActive(true);
        }
        else if (coin <= 0)
        {
            coin_object.SetActive(false);
        }
        else if (gem <= 0) {
            gem_object.SetActive(false);
        }

        coin_text.text = 25 + " / " + coin;
        gem_text.text = 15 + " / " + gem;
    }

    public void Coin()
    {
        //Time.timeScale = 1;
        coin -= 25;
        PlayerPrefs.SetInt("Coin", coin);
        revive_menu.SetActive(false);
        Player_Controller.player_checker = true;
        Health_Bar.health_point = 100f;
        Health_Bar.Text_point = 100;
        Time.timeScale = 1.0f;
    }

    public void Gem()
    {
        //Time.timeScale = 1;
        gem -= 15;
        PlayerPrefs.SetInt("Gem", gem);
        revive_menu.SetActive(false);
        Player_Controller.player_checker = true;
        Health_Bar.health_point = 100f;
        Health_Bar.Text_point = 100;
        Time.timeScale = 1.0f;
    }

    public void Exit_Button()
    {
        revive_menu.SetActive(false);
        Game_over_menu.SetActive(true);
    }
}
