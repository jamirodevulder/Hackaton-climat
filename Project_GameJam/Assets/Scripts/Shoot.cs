using UnityEngine;
using System.Collections;
public class Shoot : MonoBehaviour
{

    public GameObject kogel;
    public GameObject spawn;
    public GameObject radius;
    public bool inRadius = false;
    public bool schiet = false;
    public string welkeTegenstander;
    public string test;
    public float speed;
    public int geraakt;
    private int teller;
    private int checker = 1;
    private string[] array = new string[50];
    void Start()
    {
        
        InvokeRepeating("Schiet", 2.0f, 5.0f);

    }
    void Update()
    {

        
        


    }
    void OnTriggerEnter(Collider collision)
    {
        print("test");
        if (collision.gameObject.tag == "tegenstander")
        {
            if (array[teller] == collision.gameObject.name)
            {
                
                
            }
            else
            {
                teller++;
                array[teller] = collision.gameObject.name;
               
            }
            if (GameObject.Find(array[checker]) != null)
             {
                
                inRadius = true;
                welkeTegenstander = array[checker];    
                print(array[checker]);
                
            }
            else
            {

                checker++;

            }

        }


        Schiet();
    }

    private void OnTriggerExit(Collider other)
    {
        checker++;
    }

    public void Schiet()
    {
        schiet = true;


    }

}