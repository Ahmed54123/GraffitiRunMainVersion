using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LightFlickeringTest : MonoBehaviour
{
    Light2D myLight;

    public float firstVar;
    public float secondVar;
    public float secondsBetweenFlickering;
    public float pointLightOuterRadiusCheck;

    float flickeringTimer;
    float shouldFlicker;

    void Start()
    {

        myLight = GetComponent<Light2D>();

        //StartCoroutine(LightFlicker());

        flickeringTimer = secondsBetweenFlickering;

        shouldFlicker = Random.Range(1, 2);

    }

    void Update()
    {
        
        pointLightOuterRadiusCheck = myLight.pointLightOuterRadius;

     
            LightFlicker();

        
    }

    //  IEnumerator LightFlicker()
    //  {
    // yield return new WaitForSeconds(secondsBetweenFlickering);
    //  myLight.pointLightOuterRadius = Random.Range(firstVar, secondVar);
    // StartCoroutine(LightFlicker());

    //  }

    void LightFlicker()
    {
        flickeringTimer -= Time.deltaTime;

        if (flickeringTimer < 0)
        {

            myLight.pointLightOuterRadius = Random.Range(firstVar, secondVar);

            flickeringTimer = secondsBetweenFlickering;
        }



    }
}
