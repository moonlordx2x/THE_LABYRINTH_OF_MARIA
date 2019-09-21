using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy_Hint_Coin_Gem : MonoBehaviour {

    public GameObject button_hint;
    public GameObject hint_menu;
    public GameObject coin_button;
    public GameObject gem_button;
    public GameObject text;

    Text coin_text;
    Text gem_text;

    int coin;
    int gem;

    // Use this for initialization
    void Start () {
        text.SetActive(false);
        hint_menu.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        coin_text = GameObject.FindGameObjectWithTag("Coin_Text").GetComponent<Text>();
        gem_text = GameObject.FindGameObjectWithTag("Gem_Text").GetComponent<Text>();

        coin = PlayerPrefs.GetInt("Coin");
        gem = PlayerPrefs.GetInt("Gem");

        coin_text.text = 25 + " / " + coin;
        gem_text.text = 15 + " / " + gem;


        if(coin <=0 && gem <= 0)
        {
            coin_button.SetActive(false);
            gem_button.SetActive(false);
            text.SetActive(true);
        }
        else if(coin <= 0)
        {
            coin_button.SetActive(false);
        }
        else if (gem <= 0)
        {
            gem_button.SetActive(false);
        }

    }


    public void Coin()
    {
        Time.timeScale = 1;
        coin -= 25;
        Hint_text.total_hint += 1;
        PlayerPrefs.SetInt("Coin", coin);
        hint_menu.SetActive(false);
        button_hint.SetActive(false);
    }

    public void Gem()
    {
        Time.timeScale = 1;
        gem -= 15;
        Hint_text.total_hint += 1;
        PlayerPrefs.SetInt("Gem", gem);
        hint_menu.SetActive(false);
        button_hint.SetActive(false);
    }

    public void Exit_menu()
    {
        Time.timeScale = 1;
        hint_menu.SetActive(false);
    }
}
