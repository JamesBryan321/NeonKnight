using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using UnityEngine;

public class Bullet : MonoBehaviour
{
  
    public float Speed;

 


    public Transform deathLocation;

    public GameObject whatToSpawn;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.forward * Speed * Time.deltaTime);

        Object.Destroy(gameObject, 2.0f);
    }
    void OnCollisionEnter(Collision collision)
    { 

        Destroy(collision.collider.gameObject);
        Destroy(gameObject);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Hit.");
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Chair")
        {
            Debug.Log("Hit_chair");
            animator.SetBool("Chair_hit", true);
        }
    }
}
