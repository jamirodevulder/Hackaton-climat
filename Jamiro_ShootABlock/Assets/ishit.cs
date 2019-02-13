using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ishit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "bullit")
        {
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "enemies")
        {
            Destroy(collision.gameObject);
        }
    }

}
