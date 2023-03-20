using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    public int score = 0;

    public class ScoreTracker
    {
        public string Player; 
        public int Score;

        public ScoreTracker(string player, int score)
        {
            this.Score = score;
            this.Player = player;

        }
    }

    public void Start()
    {
        ScoreTracker Player1 = new ScoreTracker("Player 1", 0);
        ScoreTracker Player2 = new ScoreTracker("Player 2", 0);
    }

    public void Update()
    {

}

public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectibles"))
        {
            Destroy(collision.gameObject);
            score++;
            Debug.Log(score);
        }
    }
}

