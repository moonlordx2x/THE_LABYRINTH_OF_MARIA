using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Generate : MonoBehaviour {

    public Image loading;
    public GameObject hint_object;
    public GameObject text_object;
    public GameObject loading_object;
    public GameObject Animation;
    float timer = 0.20f;

    Animator hind_animator;
    // Use this for initialization
    void Start () {

        text_object.SetActive(true);
        loading_object.SetActive(true);
        Animation.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {


        loading.fillAmount += timer * Time.deltaTime;
        if (loading.fillAmount >= 1)
        {
            loading_object.SetActive(false);
            text_object.SetActive(true);
            Animation.SetActive(true);
        }

    }
}
