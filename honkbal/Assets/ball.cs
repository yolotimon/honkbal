using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ball : MonoBehaviour
{
    [SerializeField] float force = 50f;
    Rigidbody rb;
    public static int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(transform.forward * force, ForceMode.Impulse);

        Destroy(gameObject, 20f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("punt1"))
        {
            points++;
            Debug.Log("you have " + points.ToString() + " points");
            Destroy(gameObject);
        }

        if (other.CompareTag("punt2"))
        {
            points+=2;
            Debug.Log("you have " + points.ToString() + " points");
            Destroy(gameObject);
        }

        if (other.CompareTag("punt3"))
        {
            points+=3;
            Debug.Log("you have " + points.ToString() + " points");
            Destroy(gameObject);
        }

        if (other.CompareTag("punt4"))
        {
            points+=4;
            Debug.Log("you have " + points.ToString() + " points");
            Destroy(gameObject);
        }

        if (other.CompareTag("punt5"))
        {
            points+=5;
            Debug.Log("you have " + points.ToString() + " points");
            Destroy(gameObject);
        }

        if (other.CompareTag("punt6"))
        {
            points+=6;
            Debug.Log("you have " + points.ToString() + " points");
            Destroy(gameObject);
        }
    }
}
