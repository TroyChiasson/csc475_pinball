using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    public float launchForce;
    //public Menu menu;
 
    private Rigidbody rb;
    //private int lives;
    //private const int MAX_LIVES = 3;

    private Vector3 spawnPosition;

    void Start()
    {
        //lives = MAX_LIVES;
        rb = GetComponent<Rigidbody>();
        spawnPosition = GameObject.FindGameObjectWithTag("BallStart").transform.position;
    }

    public void Launch()
    {
        rb.AddForce(Vector3.forward * launchForce, ForceMode.Impulse);
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
        if (other.CompareTag("BallEnd")) {
            // Get reference to ball's prefab
            GameObject prefab = gameObject;

            // Destry ball
            Destroy(gameObject);

            // Decrement ActiveBalls counter
            GameManager.Instance.AddActiveBalls(-1);

            // If no ActiveBalls
            if (GameManager.Instance.ActiveBalls < 1) {
                // Decrement Life counter
                GameManager.Instance.AddLife(-1);

                // Create new ball
                Instantiate(prefab, spawnPosition, Quaternion.identity);

                // Increment ActiveBalls counter
                GameManager.Instance.AddActiveBalls(1);
            }   
        }
    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        var bumper = collision.gameObject.GetComponent<Bumper>();
        if (bumper != null)
        {
            //bumper.Bump();
        }
    }
    */
}
