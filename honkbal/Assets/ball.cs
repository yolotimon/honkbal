using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ball : MonoBehaviour
{
    public static float dist;
    [SerializeField] float force = 13f;
    Rigidbody rb;
    //public static int points = 0;
    //GameObject bean;
    private GameObject middle;
    private GameObject canvas;

    audiomanager manager;

    private bool ground = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //bean = GameObject.Find("capsule");

        rb.AddForce(transform.forward * force, ForceMode.Impulse);

        middle = GameObject.Find("Capsule");

        canvas = GameObject.Find("wristCanvas");
    }

    private void Awake()
    {
        manager = GameObject.FindGameObjectWithTag("audio").GetComponent<audiomanager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "landing")
        {
            ground = true;
        }

        if (collision.gameObject.tag == "ground")
        {
            Destroy(gameObject);
            ButtonVR.ballIngame = false;
        }

        if (collision.gameObject.CompareTag("knuppel"))
        {
            audiomanager.playKnuppel(audiomanager.Ballhit);
        }
    }

    private void Update()
    {
        var jesterFind = GameObject.Find("baseball");
        var jesterPosition = jesterFind.transform.position;

        if (ground == true)
        {
            dist = Vector3.Distance(new Vector3(jesterPosition.x, 0, jesterPosition.z), new Vector3(middle.transform.position.x, 0, middle.transform.position.z));
            //print("Distance to player: " + Mathf.Round(dist));
            canvas.GetComponent<scoreManager>().SaveScore();
            Destroy(gameObject);
            ButtonVR.ballIngame = false;
        }
    }




    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("punt1"))
    //    {
    //        points++;
    //        Debug.Log("you have " + points.ToString() + " points");
    //        Destroy(gameObject);
    //    }

    //    if (other.CompareTag("punt2"))
    //    {
    //        points+=2;
    //        Debug.Log("you have " + points.ToString() + " points");
    //        Destroy(gameObject);
    //    }

    //    if (other.CompareTag("punt3"))
    //    {
    //        points+=3;
    //        Debug.Log("you have " + points.ToString() + " points");
    //        Destroy(gameObject);
    //    }

    //    if (other.CompareTag("punt4"))
    //    {
    //        points+=4;
    //        Debug.Log("you have " + points.ToString() + " points");
    //        Destroy(gameObject);
    //    }

    //    if (other.CompareTag("punt5"))
    //    {
    //        points+=5;
    //        Debug.Log("you have " + points.ToString() + " points");
    //        Destroy(gameObject);
    //    }

    //    if (other.CompareTag("punt6"))
    //    {
    //        points+=6;
    //        Debug.Log("you have " + points.ToString() + " points");
    //        Destroy(gameObject);
    //    }
    //}

    //void Example()
    //{
    //    if (bean.transform)
    //    {
    //        float dist = Vector3.Distance(bean.transform.position, transform.position);
    //        print("Distance to player: " + dist);
    //    }
    //}
}
