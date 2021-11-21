using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;
    public float speed = 150.0f;

    void FixedUpdate()
    {
        if (Input.GetKeyDown("w")) {
          rb.AddForce(transform.forward * speed);
        } else if (Input.GetKeyDown("s")) {
          rb.AddForce(-transform.forward * speed);
        } else if (Input.GetKeyDown("a")) {
          rb.AddForce(-transform.right * speed);
        } else if (Input.GetKeyDown("d")) {
          rb.AddForce(transform.right * speed);
        }
    }
}
