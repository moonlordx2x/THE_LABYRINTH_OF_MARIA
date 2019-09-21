using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene("Start_Menu");
    }

    public void hidden_object_stage()
    {
        SceneManager.LoadScene("Hidden_Object_Stage_Select");
    }

    public void hidden_object()
    {
        SceneManager.LoadScene("Hidden_Object_1");
    }

    public void hidden_object_2()
    {
        SceneManager.LoadScene("Hidden_Object_2");
    }

    public void hidden_object_3()
    {
        SceneManager.LoadScene("Hidden_Object_3");
    }

    public void hidden_object_4()
    {
        SceneManager.LoadScene("Hidden_Object_4");
    }

    public void hidden_object_5()
    {
        SceneManager.LoadScene("Hidden_Object_5");
    }


    public void Dodge_Stage_1()
    {
        SceneManager.LoadScene("Dodge_Stage_1");
    }

    public void Dodge_Stage_2()
    {
        SceneManager.LoadScene("Dodge_Stage_2");
    }

    public void Dodge_Stage_3()
    {
        SceneManager.LoadScene("Dodge_Stage_3");
    }

    public void Dodge_Stage_Select()
    {
        SceneManager.LoadScene("Dodge_Stage_Select");
    }


    public void Werewolf_Stage_1()
    {
        SceneManager.LoadScene("Werewolf_Stage_Boss");
    }

    public void Werewolf_Stage_Select()
    {
        SceneManager.LoadScene("Werewolf_Stage_Select");
    }

    public void Main_Stage_Menu()
    {
        SceneManager.LoadScene("Main_Stage_Menu");
        //SceneManager.LoadScene("Hidden_Object_Sample");
        //PlayerPrefs.DeleteAll();
        

        if (PlayerPrefs.GetString("Game_Coins") == "")
        {
            PlayerPrefs.SetInt("Coin", 500);
            PlayerPrefs.SetInt("Gem", 500);
            PlayerPrefs.SetString("Game_Coins", "Game_Active");
        }
        else
        {
            Debug.Log(PlayerPrefs.GetInt("Coin")+"  "+ PlayerPrefs.GetInt("Gem"));
        }
        PlayerPrefs.SetString("hidden_object_1", "Completed");
        PlayerPrefs.SetString("hidden_object_2", "Completed");
        PlayerPrefs.SetString("hidden_object_3", "Completed");
        PlayerPrefs.SetString("hidden_object_4", "Completed");
        PlayerPrefs.SetString("hidden_object_5", "Completed");

        PlayerPrefs.SetInt("hidden_object_star_1", 3);
        PlayerPrefs.SetInt("hidden_object_star_2", 3);
        PlayerPrefs.SetInt("hidden_object_star_3", 3);
        PlayerPrefs.SetInt("hidden_object_star_4", 3);
        PlayerPrefs.SetInt("hidden_object_star_5", 3);

        PlayerPrefs.SetString("Survival_2", "Completed");
        PlayerPrefs.SetString("Survival_3", "Completed");
        PlayerPrefs.SetString("Survival_4", "Completed");
    }
}
