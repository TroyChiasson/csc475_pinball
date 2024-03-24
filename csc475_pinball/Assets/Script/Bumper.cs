using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour {
    public float force;

    void OnCollisionEnter(Collision col) {
        Debug.Log("Collision!");
        if(col.gameObject.tag == "Ball") {
            Debug.Log("With Ball!");
            // Get the rigid body of the collided ball
            Rigidbody ballrb = col.gameObject.GetComponent<Rigidbody>();
            // Calculate angle between the collision point and the ball
            Vector3 dir = col.contacts[0].point - transform.position;
            // Get opposite angle (-Vector3) and normalize it
            dir = -dir.normalized;
            // Add force in the direction of dir and multiply it by force
            ballrb.AddForce(dir * force, ForceMode.Impulse);
        }
    }
}
