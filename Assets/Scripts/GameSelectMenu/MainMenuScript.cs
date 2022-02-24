using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Required container for scene management
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void SceneLoad(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
