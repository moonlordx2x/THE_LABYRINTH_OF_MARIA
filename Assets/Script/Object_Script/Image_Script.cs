using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Script : MonoBehaviour {

    public static GameObject[] hint_object;
    Sprite sprite;

    //Text_Script text_Script;
    // Use this for initialization
    void Start () {
        /*
     hint_object = GameObject.FindGameObjectsWithTag("hint_object");

          for (int i = 0; i < 10; i++)
          {
              hint_object[i].name = Text_Script.hidden_object[i].name;
              sprite = Resources.Load(hint_object[i].name, typeof(Sprite)) as Sprite;
              hint_object[i].GetComponentInChildren<Image>().sprite = sprite;
          }



          this.gameObject.name = sample;
          sprite = Resources.Load(sample, typeof(Sprite)) as Sprite;
          Debug.Log(sprite);
          this.gameObject.GetComponent<Image>().sprite = sprite;
          */
    }

    // Update is called once per frame
    void Update () {
    }
}
