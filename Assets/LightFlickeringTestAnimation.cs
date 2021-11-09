using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlickeringTestAnimation : MonoBehaviour
{

    public GameObject pointLightObject;
    Animator flickerAnimator;

    void Start()
    {
        
        flickerAnimator = GetComponent<Animator>();


    }

    void Update()
    {
        LightFlickeringTest pointLightObjectRef = pointLightObject.GetComponent<LightFlickeringTest>();

        flickerAnimator.SetFloat("Blend", pointLightObjectRef.pointLightOuterRadiusCheck);



    }
}
