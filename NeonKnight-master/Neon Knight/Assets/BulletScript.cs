using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.GetComponent<Enemy>().health --;
            Debug.Log("enemy shot");
        }
    }
}
