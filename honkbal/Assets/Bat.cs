using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    [SerializeField] GameObject Ball;
    Rigidbody rb;
    [SerializeField] float force = 50f;

    private void Start()
    {
        rb = Ball.GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            print("kaboom");
            rb.AddForce(transform.forward * force, ForceMode.Impulse);
        }
    }
}
