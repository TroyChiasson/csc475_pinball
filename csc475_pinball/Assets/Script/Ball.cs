using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    public float launchForce; //used force to launch the ball
    public ParticleSystem collisionParticles;
    //public Menu menu;

    private Rigidbody rb;
    private bool canLaunch; //used to prevent launching ball more than once
    //private int lives;
    //private const int MAX_LIVES = 3;

    private Vector3 spawnPosition;

    private void Start()
    {
        //lives = MAX_LIVES;
        rb = GetComponent<Rigidbody>();
        canLaunch = true;
        //spawnPosition = GameObject.FindGameObjectWithTag("BallStart").transform.position;
    }

    private void Update()
    {
        var input = GameManager.Instance.input;
        if (canLaunch && input.Default.LaunchBall.WasReleasedThisFrame())
        {
            Launch();
        }
    }
    /*
    public void Restart()
    {
        rb.velocity = Vector3.zero;
        //lives = MAX_LIVES;
    }
    */

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BallEnd"))
        {
            // Get reference to ball's prefab
            GameObject prefab = gameObject;

            // Destry ball
            Destroy(gameObject);

            // Decrement ActiveBalls counter
            GameManager.Instance.AddActiveBalls(-1);

            // If no ActiveBalls
            if (GameManager.Instance.ActiveBalls < 1)
            {
                // Decrement Life counter
                GameManager.Instance.AddLife(-1);

                // Create new ball
                //Instantiate(prefab, spawnPosition, Quaternion.identity);
                GameManager.Instance.SpawnBall("BallStart");

                // Increment ActiveBalls counter
                GameManager.Instance.AddActiveBalls(1);

                //
                canLaunch = true;
            }
        }
    }


    public void Launch()
    {
        // add force in the direction the ball needs to go
        float actualLaunchForce = Random.Range(launchForce * 0.8f, launchForce * 1.2f);
        rb.AddForce(Vector3.forward * actualLaunchForce, ForceMode.Impulse);

        canLaunch = false;
    }

    public void ResetBall()
    {
        transform.position = GameObject.FindGameObjectWithTag("ballStart").transform.position;
        rb.velocity = Vector3.zero;
        canLaunch = true;
    }

}