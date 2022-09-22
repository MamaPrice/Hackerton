using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ARSceneManager : MonoBehaviour
{
    public void GotoMain()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }

    public void GotoScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
    public void mission_complete()
    {
        if(PlayerPrefs.GetInt(SceneManager.GetActiveScene().name)==1)
        {
            Debug.Log("mission complete");
            SceneManager.LoadScene("Map_Choice", LoadSceneMode.Single);
        }
        else
        {
            Debug.Log("plz complete");
        }
    }
}
