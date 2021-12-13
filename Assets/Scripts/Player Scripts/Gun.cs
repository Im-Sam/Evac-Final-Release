
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gun : MonoBehaviour
{
    public float damage = 20;
    public float range = 1000;
    public int hitCounter;
    AudioSource m_ShootingSound;
    EnemyManager enemyManagerScript;

    public Camera fpsCam;

    void Start()
    {
        m_ShootingSound = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            m_ShootingSound.Play();
        }

    }
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            ZombieHealth zombie = hit.transform.GetComponent<ZombieHealth>();

            if (zombie != null)
            {
                zombie.DecreaseHealth(damage);
                hitCounter++;
                if (hitCounter == 120){
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
        }
    }
}
