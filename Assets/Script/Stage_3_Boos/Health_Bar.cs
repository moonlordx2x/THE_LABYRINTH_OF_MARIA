using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Bar : MonoBehaviour {

    public Image healthbar;
    public Text Textbar;

    public GameObject Gameover;

    float health_total;
    public static float health_point;
    public static int Text_point;
    // Use this for initialization
    void Start () {
        Gameover.SetActive(false);
        health_point = 100f;
        Text_point = 100;
        health_total = 100f;
    }
	
	// Update is called once per frame
	void Update () {
        healthbar.fillAmount = health_point / health_total;
        Textbar.text = health_point + " / " + health_total;

        if(healthbar.fillAmount <= 0)
        {
            health_point = 100f;
            Textbar.text = 0 + " / " + health_total;
            Gameover.SetActive(true);
            Time.timeScale = 0;
            
        }

    }
}
