using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Rigidbody2D Wall;
    [SerializeField] private float speed;
    [SerializeField] private bool random;

   
    // Start is called before the first frame update
    void Start()
    {
        Wall = this.GetComponent<Rigidbody2D>();
        Wall.velocity = new Vector2(speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
       /* transform.Translate(speed * Time.deltaTime, 0, 0);
        if(transform.position.x < -7)
        {
            Wall.transform.position = new Vector3(7, Wall.transform.position.y, Wall.transform.position.z);
        }
       */
        
    }
}
