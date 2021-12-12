
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 50;
    public float range = 1000;
    AudioSource m_ShootingSound;

    public Camera fpsCam;

    void Start(){
        m_ShootingSound = GetComponent<AudioSource>();
    }
    
 
    void Update(){
        if (Input.GetButtonDown("Fire1")){
            Shoot();
            m_ShootingSound.Play();
        }
        
    }
    void Shoot(){
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)){
            ZombieHealth zombie = hit.transform.GetComponent<ZombieHealth>();

            if (zombie != null){
                zombie.DecreaseHealth(damage);
            }
        }
    }
}
