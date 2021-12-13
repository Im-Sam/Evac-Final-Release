using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Map 1");
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Map 1"));
    }
}
