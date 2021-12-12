using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour{

private float health;
public GameObject HealthBar;
public float maxHealth = 100;
    

    public void Start(){
        health = maxHealth;
    }
    
    public void AddHealth(float amount){
        health += amount;
     
        UpdateHealthBar();
        
    }
      
      
      public void DecreaseHealth(float amount){
        health -= amount;
        
        if (health <= 0)
        {
            health = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            health = maxHealth;
           
        }
        UpdateHealthBar();

    }
    public void UpdateHealthBar(){
        float fillAmount = health / maxHealth;
        if (fillAmount > 1)
        {
            fillAmount = 1;
        }

        HealthBar.GetComponent<Image>().fillAmount = fillAmount;
    }

}
    

