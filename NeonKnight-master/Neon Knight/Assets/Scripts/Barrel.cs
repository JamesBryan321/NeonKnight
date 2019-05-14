using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    private bool exploded = false;
    public GameObject explosionEffect;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (!exploded)
        {
            Explode();
            exploded = true;
        }
    }

    void Explode()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Debug.Log("Boom!");
        Destroy(gameObject);
    }
}
