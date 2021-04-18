using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public Animator DoorAnim;
    // Start is called before the first frame update
    void Start()
    {
        DoorAnim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Open door");
            Debug.Log("Open door");
            DoorAnim.SetTrigger("Open");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            DoorAnim.SetTrigger("closed");
        }
    }
}
