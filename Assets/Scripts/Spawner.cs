using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] chasers;

    public Transform[] spawnPoint;

    private int rand;
    private int randPosition;

    public float startTimeBtwSpawns;

    private float timeBtwSpawns;

    // Start is called before the first frame update
    void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;   
    }

    // Update is called once per frame
    void Update()
    {
        if(timeBtwSpawns <= 0)
        {
            rand = Random.Range(0, chasers.Length);
            randPosition = Random.Range(0, spawnPoint.Length);
            Instantiate(chasers[rand], spawnPoint[randPosition].transform.position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
