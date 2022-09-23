using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int[] jellyGoldList;
    public Vector3[] PointList;
    public GameObject MenuSet;

    public RuntimeAnimatorController[] LevelAc;

    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            MenuSet.SetActive(true);
        }
    }
    public void ChangeAc(Animator anim, int level)
    {
        anim.runtimeAnimatorController = LevelAc[level-1];
    }
}
