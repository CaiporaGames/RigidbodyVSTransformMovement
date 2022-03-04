using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBAcc : MonoBehaviour
{
    public float speed = 0.5f;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {              
        rb.AddForce(transform.right * speed * Time.deltaTime);
    }
}
