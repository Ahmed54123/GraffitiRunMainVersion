using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerProjectile : MonoBehaviour
{
    Rigidbody2D rb2d;

    Animator projectileAnimator;
    public GameObject explosionParticleEffect;

    float timerExploded;
    public float animationTime;
    bool timeUp;

     AudioSource playerProjectileAudio;
    public AudioClip playerProjectileExploded;

   

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();

        projectileAnimator = GetComponent<Animator>();

        timerExploded = animationTime;
        timeUp = false;

        playerProjectileAudio = GetComponent<AudioSource>();

        

    }

    void Update()
    {
        if (timeUp == true)
        {
           timerExploded -= Time.deltaTime;
            animatorController.AnimControllerinstance.hasPlayerProjectileExploded = true;




            if (timerExploded < 0)
            {
                animatorController.AnimControllerinstance.hasPlayerProjectileExploded = false;
                Destroy(gameObject);
            }

        }

        if (transform.position.magnitude > 500.0f)
        {
            Destroy(gameObject);
        }


    }

    public void Shoot(Vector2 direction, float force)
    {
        rb2d.AddForce(direction * force);

    }

    void OnCollisionEnter2D(Collision2D other)
    {

        //projectileAnimator.SetTrigger("Exploded");

        Instantiate(explosionParticleEffect, rb2d.position, Quaternion.identity);

        playerProjectileAudio.PlayOneShot(playerProjectileExploded);

        timeUp = true;

    }


    




    
}
