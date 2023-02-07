using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        moveBall();
    }

    private void moveBall()
    {
        float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(speed * sx, speed * sy, 0f);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Trigger1")
        {
            Reset();
        }

        if (other.gameObject.name == "Trigger2")
        {
            Reset();
        }
    }

    private void Reset()
    {
        transform.position = new Vector3(0, 0, 0);
        moveBall();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
