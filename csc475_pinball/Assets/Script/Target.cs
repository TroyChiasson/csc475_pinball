using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Target : MonoBehaviour {
    public float force;

    public int points = 1;  

    public float fadeDuration;
    private Light targetLight;
    private float initialIntensity;

    public float spinDuration;
    public float initialSpeed;
    public Vector3 rotationAxis;

    private Transform scorePopup;
    private Vector3 initialScorePopupPosition;
    private Rigidbody scorePopupRigidBody;
    public float jumpHeight;
    public Vector3 jumpDirection;
    public float driftMod = 0;
    public float lifeTime;

    private AudioSource audioSource;

    void Start()
    {
        // Get target's light component
        targetLight = GetComponent<Light>();
        // Store the initial intensity of the light
        initialIntensity = targetLight.intensity;
        // Turn off light
        targetLight.intensity = 0f;



        //
        scorePopup = transform.GetChild(0);//.gameObject;

        //
        scorePopup.gameObject.SetActive(false);
        
        //
        initialScorePopupPosition = scorePopup.position;

        //
        jumpDirection = jumpDirection.normalized;

        //
        //driftMod += 1;



        //
        audioSource = GetComponent<AudioSource>();
        //
        audioSource.Stop();



        // Start recursive search from parent to change text
        ChangeTextInChildren(transform);
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Ball") {
            // Get the rigid body of the collided ball
            Rigidbody ballrb = other.gameObject.GetComponent<Rigidbody>();

            // Calculate angle between the collision point and the ball
            Vector3 direction = (other.transform.position - transform.position).normalized;

            // Add force in the direction of dir and multiply it by force
            ballrb.AddForce(direction * force, ForceMode.Impulse);

            // Start coroutine for fade out
            StartCoroutine(FadeOutLight());

            // Start coroutine for spin
            StartCoroutine(Spin());

            // Start coroutine for score popup
            StartCoroutine(ScorePopup());

            // Add score
            GameManager.Instance.AddScore(points);

            // Play sound
            Debug.Log("Playingsound");
            audioSource.Play();
        }
    }

    IEnumerator FadeOutLight() {
        float elapsedTime = 0f;

        // Gradually decrease the intensity using the ease-out cubic function
        while (elapsedTime < fadeDuration) {
            float t = elapsedTime / fadeDuration;
            float intensity = initialIntensity - initialIntensity * EaseOutCubic(t);
            targetLight.intensity = intensity;
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Make sure the intensity reaches zero after the fade out
        targetLight.intensity = 0f;
    }

    IEnumerator Spin() {
        float elapsedTime = 0f;

        // Gradually decrease the intensity using the ease-out cubic function
        while (elapsedTime < spinDuration) {
            float t = elapsedTime / spinDuration;
            float rotationSpeed = initialSpeed - initialSpeed * EaseOutCubic(t);
            transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
            elapsedTime += Time.deltaTime;

            // Counter rotate ScorePopups
            //scorePopups.transform.Rotate(rotationAxis, -rotationSpeed * Time.deltaTime);
            // silly anchor moment

            yield return null;
        }
        transform.Rotate(rotationAxis, 0f);
        //scorePopups.transform.Rotate(rotationAxis, 0f);
    }

    IEnumerator ScorePopup() {
        scorePopupRigidBody = scorePopup.GetComponent<Rigidbody>();
        scorePopupRigidBody.velocity = Vector3.zero;

        scorePopup.position = initialScorePopupPosition;

        
        //jumpDirection = (jumpDirection * jumpHeight) * new Vector3(UnityEngine.Random.Range(-driftMod, driftMod), UnityEngine.Random.Range(-driftMod, driftMod), UnityEngine.Random.Range(-driftMod, driftMod));

        Vector3 finalDirection = new Vector3(
            (jumpDirection.x + UnityEngine.Random.Range(-driftMod, driftMod)) * jumpHeight,
            (jumpDirection.y + UnityEngine.Random.Range(-driftMod, driftMod)) * jumpHeight,
            (jumpDirection.z + UnityEngine.Random.Range(-driftMod, driftMod)) * jumpHeight
        );
        scorePopup.gameObject.SetActive(true);
        scorePopupRigidBody.AddForce(finalDirection, ForceMode.Impulse);
        yield return new WaitForSeconds(lifeTime);
        scorePopup.gameObject.SetActive(false);
    }

    // Ease-out cubic function
    float EaseOutCubic(float t) {
        t--;
        return t * t * t + 1;
    }

    void ChangeTextInChildren(Transform currentTransform) {
        // Check if the current transform has a TextMeshPro component attached
        TMP_Text textMeshProComponent = currentTransform.GetComponent<TMP_Text>();
        if (textMeshProComponent != null) {
            // If a TextMeshPro component is found, change its text
            textMeshProComponent.text = points.ToString();
        }

        // Recursively search through all children of the current transform
        for (int i = 0; i < currentTransform.childCount; i++) {
            Transform child = currentTransform.GetChild(i);
            ChangeTextInChildren(child);
        }
    }
}
