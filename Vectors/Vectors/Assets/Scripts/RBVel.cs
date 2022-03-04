using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBVel : MonoBehaviour
{
    public float velocity = 0.5f;
    public float acceleration = 0.5f;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = transform.right * velocity * Time.deltaTime;
        //Acceleration
        velocity = velocity + acceleration * Time.deltaTime;
    }
}
