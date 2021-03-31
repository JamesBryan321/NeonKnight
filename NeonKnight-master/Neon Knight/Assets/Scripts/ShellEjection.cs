using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellEjection : MonoBehaviour
{
    public Rigidbody myRigidbody;

    public float force;

    float lifetime = 4;

    // Use this for initialization
    void Awake()
    {

        myRigidbody.AddForce(transform.right * force);
        myRigidbody.AddTorque(Random.insideUnitSphere * force);

    }

    void Update()
    {
        Object.Destroy(gameObject, 2.0f);
    }
}
