using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint_text : MonoBehaviour {

    public static int total_hint = 2;
    public Text hint_text;
	
	void Start () {
        total_hint = 2;
    }
	
	
	void Update () {
        hint_text.text = "" + total_hint;
    }
}
