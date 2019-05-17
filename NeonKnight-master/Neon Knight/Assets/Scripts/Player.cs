using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public float fireRate;
    public float mGFireRate;
    private float nextFire;

    public FixedJoystick joyStick1;

    public FixedJoystick joyStick2;

    public Image HealthBar;

    public float PlayerHealth = 100;

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

    public bool PickUp;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();

        Move.enabled = true;
        arrow1.enabled = true;
        aim.enabled = false;
        arrow2.enabled = false;
        PickUp = false;

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

            if (PickUp == false)
            {
                if (Time.time > nextFire)
                {

                    fire();
                    anim.SetTrigger("Shoot");
                    nextFire = Time.time + fireRate;
                }
            }
            else if(PickUp == true)
            {
                if (Time.time > nextFire)
                {
                    fire();
                    anim.SetTrigger("Shoot");
                    nextFire = Time.time + mGFireRate;
                }
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
        if(other.gameObject.tag == "Enemy")
        {
            Hit();
        }
        if (other.gameObject.tag == "PickUp")
        {
            PickUp = true;
            Invoke("SetBoolBack", 30f);
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

    void Hit()
    {
        PlayerHealth = PlayerHealth - 5; 

        HealthBar.fillAmount = PlayerHealth / 100f;

        if(PlayerHealth <= 0)
        {
            SceneManager.LoadScene("Menu1");
        }
    }
   

    private void SetBoolBack()
    {
        PickUp = false;
    }

}
