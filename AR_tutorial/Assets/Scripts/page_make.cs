using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class page_make : MonoBehaviour
{
   public void page_up()
   {
        PlayerPrefs.SetInt("page_num", PlayerPrefs.GetInt("page_num")+1);
   }
   public void page_down()
   {
        if(PlayerPrefs.GetInt("page_num")!=0)
        {
            PlayerPrefs.SetInt("page_num", PlayerPrefs.GetInt("page_num") - 1);
        }
   }
}
