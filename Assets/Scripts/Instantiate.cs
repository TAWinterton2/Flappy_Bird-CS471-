using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject wall;
    [SerializeField] private Transform spawnPoint;

    private void Start()
    {
        Instantiate(wall, spawnPoint.position, spawnPoint.rotation);
    }

}
