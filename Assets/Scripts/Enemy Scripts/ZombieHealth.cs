using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour{

    
    public float health;


     public void DecreaseHealth(float amount){
        health -= amount;
       
        if (health <= 0){
            dead();
        } 
    }


    private void dead(){
       Destroy(gameObject);   
    
    }


}
