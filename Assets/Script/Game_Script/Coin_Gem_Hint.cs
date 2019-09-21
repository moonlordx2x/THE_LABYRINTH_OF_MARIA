using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Gem_Hint : MonoBehaviour {

    public GameObject hint_menu;

    // Use this for initialization
    void Start () {
        //hint_menu.SetActive(false);

    }

    public void Hint_menu()
    {
        Time.timeScale = 0;
        hint_menu.SetActive(true);
    }
}
