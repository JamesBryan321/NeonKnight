using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{

    public FixedJoystick joyStick1;

    public FixedJoystick joyStick2;

 

    public float PlayerSpeed;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(joyStick1.Horizontal * PlayerSpeed, rigidbody.velocity.y, joyStick1.Vertical * PlayerSpeed);





    }

}
