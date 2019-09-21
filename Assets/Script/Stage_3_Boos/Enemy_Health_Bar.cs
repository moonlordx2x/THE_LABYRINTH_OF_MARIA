using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Health_Bar : MonoBehaviour {

    public Image healthbar;
    public Text Textbar;


    public GameObject Success;

    float health_total = 200f;
    public static float health_point = 200f;
    public static int Text_point = 200;
    // Use this for initialization
    void Start()
    {
        Success.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.fillAmount = health_point / health_total;
        Textbar.text = health_point + " / " + health_total;

        if (healthbar.fillAmount <= 0)
        {
            Success.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
