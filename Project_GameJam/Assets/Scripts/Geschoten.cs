using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geschoten : MonoBehaviour {
    private float x;
    private float y;
    private float z;
    public float speed;
    private string geraakt;
    private int teller;
    private string naam;
    public GameObject radius;
    public GameObject kogel;
    private float kx;
    private float ky;
    private float kz;
    private bool schieten = true;


    // Use this for initialization
    void Start () {


        
        kx = kogel.transform.position.x;
        ky = kogel.transform.position.y;
        kz = kogel.transform.position.z;

    }
	
	// Update is called once per frame
	void Update () {
        
        GameObject hut = GameObject.Find("Radius");
        Shoot shoot = hut.GetComponent<Shoot>();
        
        Shoot schietIk = radius.GetComponent<Shoot>();

        

        if (schietIk.inRadius)
        {
            if (schietIk.schiet)
            {
                if (schieten)
                {
                    
                    naam = schietIk.welkeTegenstander;

                    if (GameObject.Find(naam) != null)
                    {

                        x = GameObject.Find(naam).transform.position.x;
                        y = GameObject.Find(naam).transform.position.y;
                        z = GameObject.Find(naam).transform.position.z;
                        DestroyAtTime();

                    }
                }
            }
        }
	}



    void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.tag == "tegenstander")
        {
            geraakt = collision.gameObject.name;

            transform.position = new Vector3(kx, ky, kz);
            
            //Destroy(GameObject.Find(naam));

            StartCoroutine(wacht());
        }
    }
    public void DestroyAtTime()
    {
        if (GameObject.Find(naam) != null)
        {
            float step = speed * Time.deltaTime;
            Vector3 eind = new Vector3(x, y, z);
            Vector3 pos = Vector3.MoveTowards(transform.position, eind, step);
            
            GetComponent<Rigidbody>().MovePosition(pos);
            
        }
    }
    IEnumerator wacht()
    {
        
        schieten = false;
        yield return new WaitForSeconds(5);
        schieten = true;
     
    }
    
}
