using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithTranslate : MonoBehaviour
{

    public Vector3 velocity = new Vector3(0.5f, 0);
    public Vector3 acceleration = new Vector3(0.5f, 0);


    private void Update()
    {       
       transform.Translate(velocity * Time.deltaTime);

        //Acceleration = (LastVelocity - FirstVelocity) / time;
        velocity = velocity + acceleration * Time.deltaTime;
    }
}


/*
 * 
 //Velocity and acceleration as scalar
 public float velocity = 0.5f;
    public float acceleration = 0.5f;


    private void Update()
    {       
       transform.Translate(Vector3.right * velocity * Time.deltaTime);

        //Acceleration = (LastVelocity - FirstVelocity) / time;
        velocity = velocity + acceleration * Time.deltaTime;
    }
 * */