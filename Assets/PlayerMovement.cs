using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;
    private Rigidbody rb;

    public class Movement
    {
        public GameObject player;
        public string UpKey;
        public string DownKey;
        public string LeftKey;
        public string RightKey;

        public Movement(string upKey, string downKey, string leftKey, string rightKey)
        {
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
        Movement Player1 = new Movement("w", "s", "a", "d");
        Movement Player2 = new Movement("up", "down", "left", "right");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}
