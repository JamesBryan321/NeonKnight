using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootScript : MonoBehaviour
{
    private Gamepad _gamepad;

    [SerializeField] private GameObject bulletPrefab, bulletSpawnPositionObject;
    
    void Start()
    {
        _gamepad = Gamepad.current;
        if (_gamepad != null)
        {
            Debug.Log("Gamepad Detected.");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_gamepad.rightTrigger.wasPressedThisFrame)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, bulletSpawnPositionObject.transform.position, bulletSpawnPositionObject.transform.rotation);
    }
}
