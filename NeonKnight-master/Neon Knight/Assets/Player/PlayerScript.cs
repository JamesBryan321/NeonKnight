using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    private Gamepad _gamepad;

    private Vector2 _leftStickInput;
    private Vector3 _moveDirection;

    private Rigidbody rB;
    public float speed;

    void Awake()
    {
        rB = gameObject.GetComponent<Rigidbody>();
        
        _gamepad = Gamepad.current;
        if (_gamepad != null)
        {
            Debug.Log("Gamepad Detected.");
        }
    }

    void Update()
    {
        _leftStickInput = _gamepad.leftStick.ReadValue();
        rB.velocity = new Vector3(_leftStickInput.x * speed, rB.velocity.y, _leftStickInput.y * speed);
        
        if (_gamepad.rightTrigger.wasPressedThisFrame)
        {
            Debug.Log("Shoot!");
        }

        
    }

    private void FixedUpdate()
    {
        //rB.velocity = (_moveDirection * speed);
    }
}
