using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed = 5f;

    // Player moving in the level
    public class UserMovement
    {
        // Creating key inputs for each movement
        public string Player;
        public string UpKey;
        public string DownKey;
        public string LeftKey;
        public string RightKey;

        // Combining inputs into a constructor for a player's movement
        public UserMovement(string player, string upKey, string downKey, string leftKey, string rightKey)
        {
            this.Player = player;

            this.UpKey = upKey;
            Input.GetKey(upKey);

            this.DownKey = downKey;
            Input.GetKey(downKey);

            this.LeftKey = leftKey;
            Input.GetKey(leftKey);

            this.RightKey = rightKey;
            Input.GetKey(rightKey);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Assigning key inputs for each player's movement
        UserMovement Player1 = new UserMovement("Player 1", "w", "s", "a", "d");
        UserMovement Player2 = new UserMovement("Player 2", "up", "down", "left", "right");

        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        // Making sure two players can move with different key inputs
        if (gameObject.tag == "Player 1" && Input.GetKey("w") || gameObject.tag == "Player 2" && Input.GetKey("up"))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (gameObject.tag == "Player 1" && Input.GetKey("s") || gameObject.tag == "Player 2" && Input.GetKey("down"))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        if (gameObject.tag == "Player 1" && Input.GetKey("a") || gameObject.tag == "Player 2" && Input.GetKey("left"))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (gameObject.tag == "Player 1" && Input.GetKey("d") || gameObject.tag == "Player 2" && Input.GetKey("right"))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}