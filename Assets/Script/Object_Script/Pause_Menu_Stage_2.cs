using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Menu_Stage_2 : MonoBehaviour {


    public GameObject Pause_menu;
    public GameObject Pause_button;

    // Use this for initialization
    void Start () {
        Time.timeScale = 1f;
        Pause_menu.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }



    public void Open_Pause_Menu()
    {
        Pause_button.SetActive(false);
        Pause_menu.SetActive(true);
        Time.timeScale = 0f;
    }


    public void Close_Pause_Menu()
    {
        Pause_button.SetActive(true);
        Pause_menu.SetActive(false);
        Time.timeScale = 1f;
    }
}
