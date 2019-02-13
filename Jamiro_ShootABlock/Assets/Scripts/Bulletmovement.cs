using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bulletmovement : MonoBehaviour {
    // Use this for initialization
    public GameObject spawner;
    public int speed;
 


    void Start()
    {
        InvokeRepeating("DestroyAtTime", 15.0f, 15.0f);
      
    }

    // Update is called once per frame
    void Update() {
        transform.position += transform.up * Time.deltaTime * (0 - speed);
  
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Cube(Clone)")
        {
            
            Destroy(this.gameObject);
            
        }
        if (collision.gameObject.tag == "destroywall")
        {
            Destroy(this.gameObject);
        }
    }
    void DestroyAtTime()
    {
        Destroy(this.gameObject);
    }
}

    

