using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deadMenu : MonoBehaviour
{
    public void respawn()
    {
        SceneManager.LoadScene("Map 1");
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Map 1"));
        Cursor.visible = false;
    }
}