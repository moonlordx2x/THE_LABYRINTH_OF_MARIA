using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_Select_Werewolf : MonoBehaviour {

    public GameObject Werewolf_text;
    public GameObject Werewolf_button;

    // Use this for initialization
    void Start () {

        if (this.gameObject.name == "Stage_Boss")
        {
            if (PlayerPrefs.GetString("Survival_4") == "")
            {
                Werewolf_text.SetActive(true);
                Werewolf_button.SetActive(false);
                Debug.Log(PlayerPrefs.GetString("Survival_4"));
            }
            else
            {
                Werewolf_text.SetActive(false);
                Werewolf_button.SetActive(true);
                Debug.Log(PlayerPrefs.GetString("Survival_4"));
            }
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
