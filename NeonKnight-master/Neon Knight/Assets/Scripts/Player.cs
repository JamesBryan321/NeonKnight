using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Player : MonoBehaviour
{
    private float fireRate = 0.35f;
    private float nextFire;

    public FixedJoystick joyStick1;

    public FixedJoystick joyStick2;

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public Transform shell;
    public Transform shellEjection;

    public float PlayerSpeed;
    private Animator anim;
    public AudioSource GunShot;


    public Text Move;
    public Image arrow1;
    public Text aim;
    public Image arrow2;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();

        Move.enabled = true;
        arrow1.enabled = true;
        aim.enabled = false;
        arrow2.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(joyStick1.Horizontal * PlayerSpeed, rigidbody.velocity.y, joyStick1.Vertical * PlayerSpeed);


        Vector3 playerDirection = Vector3.right * joyStick2.Horizontal + Vector3.forward * joyStick2.Vertical;
        if (playerDirection.sqrMagnitude > 0.0f)
        {
            transform.rotation = Quaternion.LookRotation(playerDirection, Vector3.up);
            if (Time.time > nextFire)
            {
                fire();
                anim.SetTrigger("Shoot");
                nextFire = Time.time + fireRate;
            }
        }




    }

    private void OnTriggerStay(Collider other)
    {


    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "aim")
        {
            aim.enabled = true;
            arrow2.enabled = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "start")
        {
            Move.enabled = false;
            arrow1.enabled = false;
        }
        if (other.tag == "aim")
        {
            aim.enabled = false;
            arrow2.enabled = false;
        }


    }
    void fire()
    {
        var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        Instantiate(shell, shellEjection.position, shellEjection.rotation);

        GunShot.Play();
    }

}
