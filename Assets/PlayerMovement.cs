using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;

    public class Movement
    {
        public string Player;
        public string UpKey;
        public string DownKey;
        public string LeftKey;
        public string RightKey;

        public Movement(string player, string upKey, string downKey, string leftKey, string rightKey)
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
        Movement Player1 = new Movement("Player 1", "w", "s", "a", "d");
        Movement Player2 = new Movement("Player 2", "up", "down", "left", "right");
    }

    // Update is called once per frame
    void Update()
    {
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