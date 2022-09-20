using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int jelatin;
    public int gold;
    public RuntimeAnimatorController[] level_ac;

    public Text jelatin_text;
    public Text gold_text;

    void LateUpdate()
    {
        //Format 함수: 숫자 텍스트의 표현식 지정
        //SmoothStep 함수: 숫자 변환 시 애니메이션 추가
        jelatin_text.text = string.Format("{0:n0}", Mathf.SmoothStep(float.Parse(jelatin_text.text), jelatin, 0.5f));
        gold_text.text = string.Format("{0:n0}", Mathf.SmoothStep(float.Parse(gold_text.text), gold, 0.5f));
    }

    public void ChangeAc(Animator anim, int level)
    {
        anim.runtimeAnimatorController = level_ac[level - 1];
    }
}
