using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Moneyviewer : MonoBehaviour
{
    public TextMeshProUGUI MoneyScore;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        MoneyScore.text = " "+PlayerPrefs.GetInt("Money");
    }
}
