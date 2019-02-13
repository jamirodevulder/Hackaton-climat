using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carspawner : MonoBehaviour
{
    public float maxTime;
    public float mininumTime;
    public GameObject[] enemies;
    public float firstcarspawn;
    // Use this for initialization
    void Start()
    {
       
        StartCoroutine("carspawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator carspawn()
    {
        while (true)
        {
            int randomcar = 0;
            yield return new WaitForSeconds(firstcarspawn);
            firstcarspawn = 0;
            Instantiate(enemies[0], new Vector3(transform.position.x, 1.8f, transform.position.z), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(mininumTime, maxTime));
        }
    }
}