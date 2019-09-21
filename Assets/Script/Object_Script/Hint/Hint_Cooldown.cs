using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint_Cooldown : MonoBehaviour {

    public Image hint_cooldown;
    float total_cooldown_time = 7f;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        if (Hint_Script.hint_cooldown_image == true)
        {
            this.gameObject.SetActive(true);
            hint_cooldown.fillAmount -= 1 / total_cooldown_time * Time.deltaTime;
            if (hint_cooldown.fillAmount <= 0)
            {
                hint_cooldown.fillAmount = 1;
                Hint_Script.hint_cooldown_image = false;
                this.gameObject.SetActive(false);
            }
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }
}
