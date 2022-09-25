using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//public string SceneName;

public class Change : MonoBehaviour
{
    public void SceneChange(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
