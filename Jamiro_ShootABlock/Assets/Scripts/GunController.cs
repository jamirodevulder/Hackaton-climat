using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class GunController : MonoBehaviour {
    
    public float rotationspeed = 1f;
    private bool CanShoot = false;
    public GameObject bulletPrefab;
    private void Start()
    {
        InvokeRepeating("shoottimer", 1f, 2f);
    }
    // Update is called once per frame
    void Update () {


        float xInput = -Input.GetAxisRaw("Horizontal");

        transform.Rotate(new Vector3(0, 0, xInput) * rotationspeed * Time.deltaTime);


        if (Input.GetKeyDown("space"))
        {
            if (CanShoot == true)
            {

                Vector3 CreateBullet = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                Instantiate(bulletPrefab, CreateBullet, transform.rotation);
                CanShoot = false;
            }


        }
         


    }
    public void shoottimer()
    {
        CanShoot = true;
    }
    
}
