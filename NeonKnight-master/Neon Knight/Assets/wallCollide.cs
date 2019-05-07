using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallCollide : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hit_chair");
            animator.SetBool("collide", true);
        }

    }
}
