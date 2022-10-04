using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    //Bird Speed 
    public float speed = 2;

    //Flap force
    public float flap = 300;


    // Start is called before the first frame update
    void Start()
    {
        //Flyt towards the right
      //  GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {

        //FLap
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * flap);
        
    }
}
