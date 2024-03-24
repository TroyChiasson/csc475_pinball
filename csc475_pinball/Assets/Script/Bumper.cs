using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bumper : MonoBehaviour {
    public float force;
    //private float light = GetComponent<Light>();
    private Light bumperLight;
    public float fadeDuration = 1f; // Duration in seconds to fade out
    private float initialIntensity;

    void Start()
    {
        // Get bumper's light component
        bumperLight = GetComponent<Light>();
        // Store the initial intensity of the light
        initialIntensity = bumperLight.intensity;
        // Turn off light
        bumperLight.intensity = 0f;
    }

    void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag == "Ball") {
            // Get the rigid body of the collided ball
            Rigidbody ballrb = col.gameObject.GetComponent<Rigidbody>();
            // Calculate angle between the collision point and the ball
            Vector3 dir = col.contacts[0].point - transform.position;
            // Get opposite angle (-Vector3) and normalize it
            dir = -dir.normalized;
            // Add force in the direction of dir and multiply it by force
            ballrb.AddForce(dir * force, ForceMode.Impulse);
            // Start coroutine for fade out.
            StartCoroutine(FadeOutLight());
        }
    }

    IEnumerator FadeOutLight() {
        // // Calculate the rate at which the intensity will decrease per second
        // float fadeRate = initialIntensity / fadeDuration;
        // // Set bumper's light to initial intensity
        // bumperLight.intensity = initialIntensity;
        // // Gradually decrease the intensity until it reaches zero
        // while (bumperLight.intensity > 0f) {
        //     bumperLight.intensity -= (float)Math.Sqrt(fadeRate * Time.deltaTime);
        //     yield return null;
        // }
        // // Make sure the intensity reaches zero after the fade out
        // bumperLight.intensity = 0f;
    
        float elapsedTime = 0f;

        // Gradually decrease the intensity using the ease-out cubic function
        while (elapsedTime < fadeDuration)
        {
            float t = elapsedTime / fadeDuration;
            float intensity = initialIntensity - initialIntensity * EaseOutCubic(t);
            bumperLight.intensity = intensity;
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Make sure the intensity reaches zero after the fade out
        bumperLight.intensity = 0f;
    }

    // Ease-out cubic function
    float EaseOutCubic(float t)
    {
        t--;
        return t * t * t + 1;
    }
}
