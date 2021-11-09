using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundAnimationScript : MonoBehaviour
{

    public Animator BackgroundAnimator;


    

    void Start()
    {

         BackgroundAnimator = GetComponent<Animator>();


    }

    void Update()
    {
        

        if (animatorController.AnimControllerinstance.hasPlayerProjectileExploded == true)
        {
            BackgroundAnimator.SetTrigger("Exploded");


         

            

        }



    }
}
