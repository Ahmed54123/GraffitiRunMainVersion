using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{

    public GameObject bulletPrefab;
    Rigidbody2D rigidbody2d;

    public Vector2 direction = new Vector2(-1, 0);
    public float bulletForce = 300;


    public float distancePlayerIsSpottedAt;
    public bool bulletShot;

    public float shotAnimDelayTime;
    float shotAnimTimer;
    public Animator enemyAnim;

    AudioSource enemyAudioSource;
    public AudioClip shootBulletAudio;

    //public bool hasBeenShot;

    void Start()
    {

        rigidbody2d = GetComponent<Rigidbody2D>();

        bulletShot = false;

        // hasBeenShot = false;

        shotAnimTimer = shotAnimDelayTime;

        enemyAudioSource = GetComponent<AudioSource>();

    }

    void Update()
    {
        if (bulletShot == true)
        {
            return;
      
        }

         if (bulletShot == false)
        {
            RaycastHit2D hit = Physics2D.Raycast(rigidbody2d.position + Vector2.up * 0.2f,
                                direction, distancePlayerIsSpottedAt, LayerMask.GetMask("Player"));
            if (hit.collider != null)
            {
                shotAnimTimer -= Time.deltaTime;
                enemyAnim.SetTrigger("Player Spotted");

                enemyAnim.SetBool("HASbeenSHOT", true);

                

                if (shotAnimTimer > 0)
                {

                    ShootBullet();
                }
            }
            
        }


        

    }

    void ShootBullet()
    {
        GameObject bulletObject = Instantiate(bulletPrefab, rigidbody2d.position + Vector2.up * 0.3f,
                                  Quaternion.identity);

        enemyProjectile bullet = bulletObject.GetComponent<enemyProjectile>();
        bullet.Shoot(direction, bulletForce);

        bulletShot = true;

        PlaySound(shootBulletAudio);


    }

    void OnCollisionEnter2D(Collision2D other)
    {
        playerProjectile PlayerProjectile = other.gameObject.GetComponent<playerProjectile>();


        if (PlayerProjectile)
        {
            rigidbody2d.transform.position = new Vector2(-27, -25);

           
        }


    }


    public void PlaySound(AudioClip clip)
    {

        enemyAudioSource.PlayOneShot(clip);
    }

}
