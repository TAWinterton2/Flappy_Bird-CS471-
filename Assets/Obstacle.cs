using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public   GameObject Thing;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        if(transform.position.x < -7)
        {
            Thing.transform.position = new Vector3(7, Thing.transform.position.y, Thing.transform.position.z);
        }

    }
}
