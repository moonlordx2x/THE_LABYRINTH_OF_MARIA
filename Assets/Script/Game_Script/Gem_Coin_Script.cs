using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gem_Coin_Script : MonoBehaviour {

    public Text Object_text;
    int coin;
    int gem;

 


    void Update () {
		
        if(Object_text.name == "Coin_Text")
        {
            coin = PlayerPrefs.GetInt("Coin");
            Object_text.text = "" + coin;
        }
        else if (Object_text.name == "Gem_Text")
        {
            gem = PlayerPrefs.GetInt("Gem");
            Object_text.text = "" + gem;
        }
    }
}
