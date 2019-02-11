using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Word_Onzichtbaar : MonoBehaviour
{
    public GameObject radius;
    public bool inRadius = false;
    public string welkeTegenstander;
    // Use this for initialization
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "tegenstander")
        {
            inRadius = true;
            welkeTegenstander = collision.gameObject.name;
            print(collision.gameObject.name);
        }
        else
        {
            inRadius = false;
        }
      
    }
}