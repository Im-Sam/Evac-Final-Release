using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour{
    public float damageAmount = 20;



private void OnCollisionEnter(Collision collision){

     if (collision.gameObject.TryGetComponent(out PlayerHealth health) && !gameObject.CompareTag("Capsule")){
                health.DecreaseHealth(damageAmount);
            }

}

 private void OnTriggerEnter(Collider other){
if (other.gameObject.TryGetComponent(out PlayerHealth health) && !gameObject.CompareTag("Capsule")){
                health.DecreaseHealth(damageAmount);
            }
}


}
