using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Script : MonoBehaviour {

    public GameObject[] Text_element_Object;
    public GameObject[] Image_element_Object;

    public static GameObject[] text_object;
    public static GameObject[] hidden_object;
    public static GameObject[] hint_object;

    Text text;
    Sprite sprite;

    public Text text_1;
    public Text text_2;
    public Text text_3;
    public Text text_4;
    public Text text_5;
    public Text text_6;
    public Text text_7;
    public Text text_8;
    public Text text_9;
    public Text text_10;

    // Use this for initialization
    void Start () {

        text_object = GameObject.FindGameObjectsWithTag("text_object");
        hidden_object = GameObject.FindGameObjectsWithTag("hidden_object");
        hint_object = GameObject.FindGameObjectsWithTag("hint_object");


        for (int i = 0;i < hidden_object.Length; i++)
        {
            GameObject sample_object = hidden_object[i];
            int rand = Random.Range(0, i);
            hidden_object[i] = hidden_object[rand];
            hidden_object[rand] = sample_object;
        }

        text_1.text = "" + hidden_object[0].name;
        text_2.text = "" + hidden_object[1].name;
        text_3.text = "" + hidden_object[2].name;
        text_4.text = "" + hidden_object[3].name;
        text_5.text = "" + hidden_object[4].name;
        text_6.text = "" + hidden_object[5].name;
        text_7.text = "" + hidden_object[6].name;
        text_8.text = "" + hidden_object[7].name;
        text_9.text = "" + hidden_object[8].name;
        text_10.text = "" + hidden_object[9].name;

        text_1.name = "" + hidden_object[0].name;
        text_2.name = "" + hidden_object[1].name;
        text_3.name = "" + hidden_object[2].name;
        text_4.name = "" + hidden_object[3].name;
        text_5.name = "" + hidden_object[4].name;
        text_6.name = "" + hidden_object[5].name;
        text_7.name = "" + hidden_object[6].name;
        text_8.name = "" + hidden_object[7].name;
        text_9.name = "" + hidden_object[8].name;
        text_10.name = "" + hidden_object[9].name;

       
        text_1.gameObject.SetActive(false);
        text_2.gameObject.SetActive(false);
        text_3.gameObject.SetActive(false);
        text_4.gameObject.SetActive(false);
        text_5.gameObject.SetActive(false);
        text_6.gameObject.SetActive(false);
        text_7.gameObject.SetActive(false);
        text_8.gameObject.SetActive(false);
        text_9.gameObject.SetActive(false);
        text_10.gameObject.SetActive(false);
        



        for (int i = 0; i < 10; i++)
        {
            /*
            text = text_object[i].GetComponentInChildren<Text>();
            text_object[i].name = hidden_object[i].name;
            text.text = "" + hidden_object[i].name;
            */

            text = Text_element_Object[i].GetComponentInChildren<Text>();
            Text_element_Object[i].name = hidden_object[i].name;
            text.text = "" + hidden_object[i].name;

            text_object[i] = Text_element_Object[i];

            Image_element_Object[i].name = hidden_object[i].name;
            sprite = Resources.Load(Image_element_Object[i].name, typeof(Sprite)) as Sprite;
            Image_element_Object[i].GetComponentInChildren<Image>().sprite = sprite;

            hint_object[i] = Image_element_Object[i];

            //Debug.Log(text_object[i].name + hidden_object[i].name + hint_object[i].name);
            //Debug.Log(sample[i].name);

        }




    }
	
	// Update is called once per frame
	void Update () {
       
    }
}
