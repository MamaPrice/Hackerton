using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Sprite[] jellySpriteList;
    public string[] jellyNameList;
    public int[] jellyJelatinList;
    public int[] jellyGoldList;
    public int[] numGoldList;
    public int[] clickGoldList;
    public Sprite[] TourSpriteList;
    public string[] TourNameList;
    public int[] TourJelatinList;
    public string[] TourLockNameList;
    public string[] TourExpainList;


    public int check=1;

    
    public Vector3[] PointList;

    public RuntimeAnimatorController[] LevelAc;

    public void ChangeAc(Animator anim, int level)
    {
        anim.runtimeAnimatorController = LevelAc[level-1];
    }


    public void Update()
    {
        if(PlayerPrefs.GetInt("Ground_map")==1&&PlayerPrefs.GetInt("Lake_map") == 1&&PlayerPrefs.GetInt("Library_map") == 1&&PlayerPrefs.GetInt("Main_Gate_map") == 1&&PlayerPrefs.GetInt("North_Gate_map") == 1)
        {
            check = 1;
        }
        else
        {
            check = 0;
        }
    }

}
