using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxObstacleScript : MonoBehaviour
{
    public Animator boxObstacleAnimator;

    


    void Start()
    {

        boxObstacleAnimator = GetComponent<Animator>();


    }

    void Update()
    {


        if (animatorController.AnimControllerinstance.hasPlayerProjectileExploded == true)
        {
            boxObstacleAnimator.SetTrigger("Exploded");


            



        }



    }
}
