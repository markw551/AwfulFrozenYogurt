using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using UnityEngine;

namespace ScoreTracker
{
    public class ScoreValueAssignment : MonoBehaviour
    {
        public int Score;

        public ScoreValueAssignment(int score)
        {
            Score = score;
        }
    }
}


