using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public class Troll
    {
        public int TrollHealth;
        public float TrollSpeed;
        public string TrollDirection;

        public Troll(int health, float speed, string direction)
        {
            this.TrollHealth = health;
            this.TrollSpeed = speed;
            this.TrollDirection = direction;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Troll One = new Troll(1, 2f, "up");
        Troll Two = new Troll(1, 2f, "down");
    }


    // Update is called once per frame
    public void Update()
    {
        float speed = 2f;
        string direction = "down";

        if (direction == "down")
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        if (direction == "up")
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        string direction = "down";

        if (direction == "down" && collision.gameObject.CompareTag("Wall"))
        {
            direction = "up";
        }

        if (direction == "up" && collision.gameObject.CompareTag("Wall"))
        {
            direction = "down";
        }
    }
}


// if starting direction is down, down is true and player moves down
//if starting direction is up, up is drue 