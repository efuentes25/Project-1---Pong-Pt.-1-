using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoPaddle : MonoBehaviour
{
    public float unitPerSec = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate(){
        if (gameObject.name == "Paddle")
        {
            float horizontalValue = Input.GetAxis("Horizontal");
            Vector3 force = Vector3.right * (horizontalValue * unitPerSec); //* Time.deltaTime;

            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(force, ForceMode.Force);
        }

        if (gameObject.name == "Paddle2")
        {
            float horizontalAD = Input.GetAxis("HorizontalAD");
            Vector3 force2 = Vector3.right * (horizontalAD * unitPerSec); // * Time.deltaTime;

            Rigidbody rb1 = GetComponent<Rigidbody>();
            rb1.AddForce(force2, ForceMode.Force);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ball")
        {
            Rigidbody rb = collision.rigidbody;
            rb.AddForce( new Vector3(10f, 10f, 0f), ForceMode.Acceleration);
            Rigidbody rb1 = collision.rigidbody;
            rb1.AddForce( new Vector3(10f, 10f, 0f), ForceMode.Acceleration);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    /*private void OnCollisionEnter(Collision collision){
        Debug.Log($"we hit {collision.gameObject.name}");
        
        // get reference to paddle collider
        BoxCollider bc = GetComponent<BoxCollider>();
        Bounds bounds = bc.bounds;
        float maxX = bounds.max.x;
        float minX = bounds.min.x;

        Debug.Log($"maxX = {maxX}, minY = {minX}");
        Debug.Log($"x pos of ball is {collision.transform.position.x}");

        Quaternion rotation = Quaternion.Euler(0f, 0f, -60f);
        Vector3 bounceDirection = rotation * Vector3.up;
        
        Rigidbody rb = collision.rigidbody;
        rb.AddForce(bounceDirection * 1000f, ForceMode.Force);
    }*/ 

}
