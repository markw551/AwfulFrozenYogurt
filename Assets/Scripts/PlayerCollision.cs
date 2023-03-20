using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
//{


//    // Update is called once per frame
//    void Update()
//    {
//        if (canCollideWithWall && gameObject.CompareTag("Wall"))
//        {
//            // Reflect the player's velocity when colliding with a wall
//            Vector2 normal = GetComponent<Collision2D>().contacts[0].normal;
//            GetComponent<Rigidbody2D>().velocity = Vector2.Reflect(GetComponent<Rigidbody2D>().velocity, normal);
//        }

//        if (canCollideWithCollectible && gameObject.CompareTag("Collectibles"))
//        {
//            // Do something when colliding with a collectible
//            Debug.Log("Player collected a collectible!");
//            Destroy(gameObject);
//        }
//    }
//}

{
    public bool canCollideWithWall = true;
    public bool canCollideWithCollectible = true;

    public class Collision
    {
        public string Wall;
        public string Item;
        public string Player;

        public Collision(string player, string wall, string item)
        {
            this.Player = player;
            this.Wall = wall;
            this.Item = item;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Collision Player1 = new Collision("Player1", "Wall", "Collectibles");
        Collision Player2 = new Collision("Player2", "Wall", "Collectibles");
    }

    // Update is called once per frame
    void Update()
    {
        if (canCollideWithWall && gameObject.tag == "Wall" && gameObject.tag == "Player1")
        {
            Vector2 normal = GetComponent<Collision2D>().contacts[0].normal;
            GetComponent<Rigidbody2D>().velocity = Vector2.Reflect(GetComponent<Rigidbody2D>().velocity, normal);
        }

            if (canCollideWithCollectible && gameObject.tag == "Collectibles" && gameObject.tag == "Player2")
        {
            Debug.Log("Collided");
        }
    }
}
