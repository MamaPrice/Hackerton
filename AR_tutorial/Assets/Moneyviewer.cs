using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moneyviewer : MonoBehaviour
{
    public Text MoneyScore;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        MoneyScore.text = " "+PlayerPrefs.GetInt("Money");
    }
}
