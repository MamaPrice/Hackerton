using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class ARSceneManager : MonoBehaviour
{
    public GameObject MenuSet;
    public GameObject quest_text_clear;
    public GameObject quest_text_noclear;
    public GameObject Clear_btn;
    public void GotoMain()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }

    public void GotoScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
    public void Mission_complete()
    {
        
        if (MenuSet.activeSelf)
        {
            MenuSet.SetActive(false);
        }
        else
        {
            MenuSet.SetActive(true);
        }
        if (PlayerPrefs.GetInt(SceneManager.GetActiveScene().name)==1)
        {
            Debug.Log("mission complete");
            quest_text_clear.SetActive(true);
            Clear_btn.SetActive(true);        
        }
        else
        {
            quest_text_noclear.SetActive(true);
            Debug.Log("plz complete");
        }
    }

    public void Reset_btn()
    {
        PlayerPrefs.SetInt("IT1_map", 0);
        PlayerPrefs.SetInt("Lake_map", 0);
        PlayerPrefs.SetInt("Main_Gate_map", 0);
    }
}
