using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public bool canCollideWithEnemy = true;

    public class Collision
    {
        public string Enemy;
        public string Player;

        public Collision(string player, string enemy)
        {
            this.Player = player;
            this.Enemy = enemy;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Collision Player1 = new Collision("Player1", "Enemy");
        Collision Player2 = new Collision("Player2", "Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        if (canCollideWithEnemy && gameObject.tag == "Enemy" && gameObject.tag == "Player1")
        {
            Debug.Log("Collided");
        }
    }
}
