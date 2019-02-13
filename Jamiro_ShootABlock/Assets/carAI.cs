using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carAI : MonoBehaviour {
    public float speed;
    public int healt = 100;
    public Transform healtbar;
    public Transform explosion;
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
                Instantiate(explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                Destroy(this.gameObject);
            }
        }
    }
}
