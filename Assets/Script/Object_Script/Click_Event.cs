using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click_Event : MonoBehaviour {

    public static string Click_event_variable;
    public static int object_found;

    Text text;
    Image image;
    Animator animator;
    Animator image_animator;

    Text_Script text_script;

    int index_array;

    // Use this for initialization
    void Start()
    {
        object_found = 0;
        text_script = gameObject.GetComponent<Text_Script>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickEvent()
    {
        Click_event_variable = this.gameObject.name.ToString();
        for (int i = 0; i < Text_Script.text_object.Length; i++)
        {
            //Debug.Log(Text_Script.text_object[i]);

            if (Text_Script.hint_object[i].activeSelf == false)
            {
                Text_Script.text_object[i].SetActive(false);
            }

            if (Text_Script.text_object[i].activeSelf == false)
            {
                Text_Script.hint_object[i].SetActive(false);
            }
        }

        if (Click_event_variable == Text_Script.hidden_object[0].name){ index_array = 0; Object_arrays(); }
        else if (Click_event_variable == Text_Script.hidden_object[1].name) { index_array = 1; Object_arrays(); }
        else if (Click_event_variable == Text_Script.hidden_object[2].name) { index_array = 2; Object_arrays(); }
        else if (Click_event_variable == Text_Script.hidden_object[3].name) { index_array = 3; Object_arrays(); }
        else if (Click_event_variable == Text_Script.hidden_object[4].name) { index_array = 4; Object_arrays(); }
        else if (Click_event_variable == Text_Script.hidden_object[5].name) { index_array = 5; Object_arrays(); }
        else if (Click_event_variable == Text_Script.hidden_object[6].name) { index_array = 6; Object_arrays(); }
        else if (Click_event_variable == Text_Script.hidden_object[7].name) { index_array = 7; Object_arrays(); }
        else if (Click_event_variable == Text_Script.hidden_object[8].name) { index_array = 8; Object_arrays(); }
        else if (Click_event_variable == Text_Script.hidden_object[9].name) { index_array = 9; Object_arrays(); }
        else 
        {
            CountDownTimer.startime -= (170f * Time.deltaTime);
            Debug.Log(170f * Time.deltaTime);      
        }

    }


    void Object_arrays()
    {
        object_found += 1;
        if (Hint_Script.hint_cooldown_time == true)
        {
            image_animator = Text_Script.hint_object[index_array].GetComponentInChildren<Animator>();
            image_animator.SetTrigger("Float");
            Text_Script.text_object[index_array].SetActive(false);
        }
        else
        {
            animator = Text_Script.text_object[index_array].GetComponentInChildren<Animator>();
            animator.SetTrigger("Float");
            Text_Script.hint_object[index_array].SetActive(false);
        }
        this.gameObject.SetActive(false);
    }

}
