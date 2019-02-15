using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carAI : MonoBehaviour {
    public float speed;
    public int healt = 100;
    public Transform healtbar;
    public Transform explosion;
    public Transform[] buildings;
    public Transform[] spawnpoints;
    private bool wait = false;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.right * Time.deltaTime * speed;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "bullit")
        {
            Destroy(collision.gameObject);
            healtbar.transform.localScale -= new Vector3(healtbar.transform.localScale.x / 2, 0, 0);
            healt -= 50;
            if(healt <= 0)
            {


                if (!wait)
                {
                    wait = true;
                    int number = Random.Range(0, 3);
                    Instantiate(buildings[number], new Vector3(spawnpoints[GunController.score].transform.position.x, spawnpoints[GunController.score].transform.position.y, spawnpoints[GunController.score].transform.position.z), Quaternion.identity);
                    GunController.score = GunController.score + 1;
                    wait = false;
                    Instantiate(explosion, new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z), Quaternion.identity);
                    Destroy(this.gameObject);
                }
                wait = false;
            }

         
        }
    }
    
}
