using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using ScoreTracker;
using System.Numerics;

public class CollisionDetection : MonoBehaviour
{
    public PlayerCollision P1 = new PlayerCollision("Player 1", 1);
    public PlayerCollision P2 = new PlayerCollision("Player 2", 1);

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (gameObject.tag == "Player 1" && collision.gameObject.CompareTag("Collectibles"))
        {
            Destroy(collision.gameObject);
            P1.Score += 1;
            UnityEngine.Debug.Log(P1.Score);
        }

        if (gameObject.tag == "Player 2" && collision.gameObject.CompareTag("Collectibles"))
        {
            Destroy(collision.gameObject);
            P2.Score += 1;
            UnityEngine.Debug.Log(P2.Score);
        }
    }
}
  
