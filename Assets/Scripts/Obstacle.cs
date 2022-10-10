using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;
    private Rigidbody2D wall;
    private Vector2 screenBounds;


    // Start is called before the first frame update
    void Start()
    {
        wall = this.GetComponent<Rigidbody2D>();
        wall.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
