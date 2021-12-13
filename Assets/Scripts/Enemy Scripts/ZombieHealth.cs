using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZombieHealth : MonoBehaviour
{
    public float health = 100;
    private int deathCounter;
    EnemyManager enemyManagerScript;
    public void DecreaseHealth(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
