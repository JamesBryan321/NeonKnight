using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    private Gamepad _gamepad;

    private Vector2 _leftStickInput, _rightStickInput;
    private Vector3 _moveDirection, _lookDirection;

    private Rigidbody _rB;
    [SerializeField] private GameObject rotatable;
    public float speed;

    void Awake()
    {
        _rB = gameObject.GetComponent<Rigidbody>();
        
        _gamepad = Gamepad.current;
        if (_gamepad != null)
        {
            Debug.Log("Gamepad Detected.");
        }
    }

    void Update()
    {
        

        
    }

    private void FixedUpdate()
    {
        _leftStickInput = _gamepad.leftStick.ReadValue();
        _rightStickInput = _gamepad.rightStick.ReadValue();
        
        _rB.velocity = new Vector3(_leftStickInput.x * speed, _rB.velocity.y, _leftStickInput.y * speed);
        
        _lookDirection =  Vector3.right * _rightStickInput.x + Vector3.forward * _rightStickInput.y;

        if (_lookDirection.sqrMagnitude > 0.0f)
        {
            rotatable.transform.rotation = Quaternion.LookRotation(_lookDirection, Vector3.up);
        }

        /*if (_gamepad.rightTrigger.wasPressedThisFrame)
        {
            Debug.Log("Shoot!");
        }*/
    }
}
