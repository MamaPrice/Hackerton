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


    public int check=1;

    
    public Vector3[] PointList;

    public RuntimeAnimatorController[] LevelAc;

    public void ChangeAc(Animator anim, int level)
    {
        anim.runtimeAnimatorController = LevelAc[level-1];
    }
}
