using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class find_hobanu : MonoBehaviour
{
    public GameObject MissionSet;
    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt(SceneManager.GetActiveScene().name)==1)
        {
            MissionSet.SetActive(true);
        }
    }
}
