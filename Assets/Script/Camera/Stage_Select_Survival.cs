using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_Select_Survival : MonoBehaviour {

    public GameObject survival_text;
    public GameObject survival_button;



    // Use this for initialization
    void Start () {


        if (this.gameObject.name == "Stage_1")
        {
            if (PlayerPrefs.GetString("Survival_1") == "")
            {
                survival_text.SetActive(true);
                survival_button.SetActive(false);
                Debug.Log(PlayerPrefs.GetString("Survival_1"));
            }
            else
            {
                survival_text.SetActive(false);
                survival_button.SetActive(true);
            }
        }

        else if (this.gameObject.name == "Stage_2")
        {
            if(PlayerPrefs.GetString("Survival_2") == "")
            {
                survival_text.SetActive(true);
                survival_button.SetActive(false);
            }
            else
            {
                survival_text.SetActive(false);
                survival_button.SetActive(true);
            }
        }

        else if(this.gameObject.name == "Stage_3")
        {
            if (PlayerPrefs.GetString("Survival_3") == "")
            {
                survival_text.SetActive(true);
                survival_button.SetActive(false);
            }
            else
            {
                survival_text.SetActive(false);
                survival_button.SetActive(true);
            }
        }


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}