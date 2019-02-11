using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TegenstanderScript : MonoBehaviour
{
    public GameObject cubePrefab;
    public float spawnThreshold = 1f;
    public static int lvl;
    private float spawnTimer = 0;
    private int count;
    private int wave;
    private int teller;

    private void Start()
    {
        lvl = 18;

    }

    void Update()
    {

        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnThreshold && count <= lvl)
        {
            count++;
            SpawnCube();
        }


    }
    private void SpawnCube()
    {
        teller++;
        Vector3 spawnPosition = new Vector3(-46.2f, -8f, -64.5f);
        cubePrefab.name = "tegenstander" + teller;
        Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
        spawnTimer = 0;


    }
    
}

