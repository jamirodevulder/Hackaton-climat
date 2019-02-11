using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
public Transform[] target;
public float speed;

private int current;




void Start()
{

}


    void Update()
    {
        if (transform.position != target[current].position)
        {

            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else if (current == 7)
        {
            
        }
        else current = (current + 1) % target.Length;
        if (current == 0)
        {
            transform.rotation = Quaternion.AngleAxis(180, Vector3.up);
        }
        if (current == 1)
        {
            transform.rotation = Quaternion.AngleAxis(90, Vector3.up);
        }
        if (current == 2)
        {
            transform.rotation = Quaternion.AngleAxis(360, Vector3.up);
        }
        if (current == 3)
        {
            transform.rotation = Quaternion.AngleAxis(90, Vector3.up);
        }
        if (current == 4)
        {
            transform.rotation = Quaternion.AngleAxis(180, Vector3.up);
        }
        if (current == 5)
        {
            transform.rotation = Quaternion.AngleAxis(270, Vector3.up);
        }
        if (current == 6)
        {
            transform.rotation = Quaternion.AngleAxis(180, Vector3.up);
        }
        if (current == 7)
        {
            transform.rotation = Quaternion.AngleAxis(270, Vector3.up);
        }
    }
    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Kogel")
        {
            Destroy(this.gameObject);


            //Destroy(GameObject.Find(naam));


        }


    }
}
