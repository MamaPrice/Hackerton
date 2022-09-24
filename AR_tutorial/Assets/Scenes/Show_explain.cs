using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_explain : MonoBehaviour
{
    public GameObject Explain_text;
    // Start is called before the first frame update
  

    // Update is called once per frame
    public void show_explain()
    {
        if (Explain_text.activeSelf)
        {
            Explain_text.SetActive(false);
        }
        else
        {
            Explain_text.SetActive(true);
        }
    }
}
