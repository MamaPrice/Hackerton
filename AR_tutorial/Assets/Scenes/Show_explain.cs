using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_explain : MonoBehaviour
{
    public GameObject Explain_text_1;
    public GameObject Explain_text_2;
    // Start is called before the first frame update

    public void first_click()
    {
        PlayerPrefs.SetInt("page_num", 0);
    }
    // Update is called once per frame
    public void show_explain()
    {
        if (PlayerPrefs.GetInt("page_num")==0 && Explain_text_1.activeSelf)
        {
            Explain_text_1.SetActive(false);
        }
        else if(PlayerPrefs.GetInt("page_num") == 0 && Explain_text_1.activeSelf==false)
        {
            Explain_text_1.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("page_num") == 1 && Explain_text_2.activeSelf)
        {
            Explain_text_2.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("page_num") == 1 && Explain_text_2.activeSelf == false)
        {
            Explain_text_2.SetActive(true);
        }
    }
}
