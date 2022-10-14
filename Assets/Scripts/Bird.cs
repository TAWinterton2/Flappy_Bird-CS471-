using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Bird : MonoBehaviour
{
    //Bird Speed 
    public float speed = 2;

    //Flap force
    public float flap = 300;

    public int score = 0;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public Button gameOverButton;
    public static bool gameOver = false;


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
        if (Input.GetKeyDown(KeyCode.Space) && !gameOver)
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * flap);
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hole")
        {
            score++;
            scoreText.text = "Score: " + score;
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else if(collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Floor")
        {
            gameOver = true;
            gameOverText.text = "GAME OVER";
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            gameOverButton.gameObject.SetActive(true);
        }
    }
}
