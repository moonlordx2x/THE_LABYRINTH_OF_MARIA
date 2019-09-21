using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Stage_Select : MonoBehaviour {


    public GameObject hidden_object_button;
    public GameObject text_object;
    public string db_playerpref_stage;
    public string star_playerpref_stage;

    public GameObject star_1;
    public GameObject star_2;
    public GameObject star_3;


    // Use this for initialization
    void Start () {

        if (PlayerPrefs.GetString(db_playerpref_stage) == "Completed")
        {
            hidden_object_button.SetActive(true);
            text_object.SetActive(false);
            
        }
        else
        {
            hidden_object_button.SetActive(false);
            text_object.SetActive(true);
            
        }

        if(PlayerPrefs.GetInt(star_playerpref_stage) == 3)
        {
            star_1.SetActive(true);
            star_2.SetActive(true);
            star_3.SetActive(true);
        }
        else if (PlayerPrefs.GetInt(star_playerpref_stage) == 2)
        {
            star_1.SetActive(true);
            star_2.SetActive(true);
            star_3.SetActive(false);
        }
        else if (PlayerPrefs.GetInt(star_playerpref_stage) == 1)
        {
            star_1.SetActive(true);
            star_2.SetActive(false);
            star_3.SetActive(false);
        }
        else
        {
            star_1.SetActive(false);
            star_2.SetActive(false);
            star_3.SetActive(false);
        }




    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
