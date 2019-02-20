using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class Player : MonoBehaviour
{


    public float moveForce;
    Rigidbody myBody;

    // Start is called before the first frame update
    void Start()
    {

        myBody = this.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector2 moveVec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) * moveForce;
        myBody.AddForce(moveVec);




    }


}
