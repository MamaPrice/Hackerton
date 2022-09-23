using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class stage_check : MonoBehaviour
{
    public GameObject IT_1_check;
    public GameObject Main_Gate_check;
    public GameObject Lake_check;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("IT1_map") == 1)
        { 
            IT_1_check.SetActive(true);
        }
        else
        {
            IT_1_check.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Main_Gate_map") == 1)
        {
           Main_Gate_check.SetActive(true);
        }
        else
        {
            Main_Gate_check.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Lake_map") == 1)
        {
            Lake_check.SetActive(true);
        }
        else
        {
            Lake_check.SetActive(false);
        }
    }
}
