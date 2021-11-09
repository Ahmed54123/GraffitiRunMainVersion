using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSkinPlayer : MonoBehaviour
{

    public AnimatorOverrideController ExplodedAnimPlayer;
    public AnimatorOverrideController NormalAnimPlayer;

    public float ExplodedPlayerOverideTimerTime;
    float ExplodedPlayerOverideTimer;
    bool didExplodeAnimHappen;

    

    void Start()
    {
        ExplodedPlayerOverideTimer = ExplodedPlayerOverideTimerTime;

        didExplodeAnimHappen = false;


    }

    void Update()
    {
        if (animatorController.AnimControllerinstance.hasPlayerProjectileExploded == true && didExplodeAnimHappen == false)
        {
            ChangeSkin(ExplodedAnimPlayer);

            didExplodeAnimHappen = true;
          

        }

         if(animatorController.AnimControllerinstance.hasPlayerProjectileExploded == false && didExplodeAnimHappen == true)
        {
            ExplodedPlayerOverideTimer -= Time.deltaTime;

            if (ExplodedPlayerOverideTimer < 0)
            {
                ChangeSkin(NormalAnimPlayer);

                ExplodedPlayerOverideTimer = ExplodedPlayerOverideTimerTime;

                didExplodeAnimHappen = false;
            }

        }
        

    }

    void ChangeSkin(AnimatorOverrideController animatorOverride)
    {

        GetComponent<Animator>().runtimeAnimatorController = animatorOverride as RuntimeAnimatorController;

        

    }
}

   
