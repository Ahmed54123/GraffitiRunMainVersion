using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorController : MonoBehaviour
{

    public static animatorController AnimControllerinstance;


    public bool hasPlayerProjectileExploded;



   

    void Awake()
    {

        if (AnimControllerinstance == null)
        {
            AnimControllerinstance = this;


        }

        else if (AnimControllerinstance != this)
        {
            Destroy(gameObject);

        }

        hasPlayerProjectileExploded = false;

        
    }

    void Update()
    {
        
      


    }



}
