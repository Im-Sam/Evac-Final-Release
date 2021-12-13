using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    public int killCount;

    public void killEnemyCount(){
        killCount++;
        Debug.Log("deathCounter = " + killCount);
    }

    void Update()
    {
        if (killCount == 2)
        {
            SceneManager.LoadScene("Map 2");
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("Map 2"));
        }
    }
}

