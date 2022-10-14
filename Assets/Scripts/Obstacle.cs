using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Bird;

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
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hole" || collision.gameObject.tag == "Wall")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

    }
}
