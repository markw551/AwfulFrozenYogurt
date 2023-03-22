using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using UnityEngine;

namespace ScoreTracker
{
    public class PlayerCollision : MonoBehaviour
    {
        public string Player;
        public int Score;

        public PlayerCollision(string player, int score)
        {
            Player = player;
            Score = score;
        }

        //public void Initialize(string player, int score)
        //{
        //    Player = player;
        //    Score = score;
        //}
    }
}


