using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Bird;

public class Instantiate : MonoBehaviour
{
    public GameObject wall;
    [SerializeField] private Transform spawnPoint;
    float time;
    float timeDelay;

    //declare time and timedelay at start of game 
    void Start()
    {
        time = 0f;
        timeDelay = 2.5f;
        Instantiate(wall, spawnPoint.position, spawnPoint.rotation);

    }


    void Update()
    {
        time = time + 1f * Time.deltaTime;

        //Spawn wall every 3 seconds
        if(time >= timeDelay && !gameOver)
        {
            time = 0f;
            Instantiate(wall, spawnPoint.position, spawnPoint.rotation);

        }

    }

}
