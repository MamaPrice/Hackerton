using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class stage_check : MonoBehaviour
{
    public GameObject North_Gate_check;
    public GameObject Main_Gate_check;
    public GameObject Lake_check;
    public GameObject Library_check;
    public GameObject Ground_check;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("North_map") == 1)
        { 
            North_Gate_check.SetActive(false);
        }
        
        if (PlayerPrefs.GetInt("Main_Gate_map") == 1)
        {
           Main_Gate_check.SetActive(false);
        }
       
        if (PlayerPrefs.GetInt("Lake_map") == 1)
        {
            Lake_check.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Library_map") == 1)
        {
            Library_check.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Ground_map") == 1)
        {
            Ground_check.SetActive(false);
        }

    }
}
