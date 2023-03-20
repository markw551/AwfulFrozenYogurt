using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class ParentClass : MonoBehaviour
//{
    
//}

public class ItemCollector : MonoBehaviour
{

    public string Collector;
    public int ScoreOne;
    public int ScoreTwo;

    public ItemCollector(string collector, int scoreone, int scoretwo)
    {
        this.ScoreOne = scoreone;
        this.ScoreTwo = scoretwo;
        this.Collector = collector;

    }

    public void Start()
    {
        ItemCollector Player1 = new ItemCollector("Player 1", 0, 0);
        ItemCollector Player2 = new ItemCollector("Player 2", 0, 0);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Player 1" &&  collision.gameObject.CompareTag("Collectibles"))
        {
            Destroy(collision.gameObject);
            ScoreOne++;
            Debug.Log(ScoreOne);
        }

        if (gameObject.tag == "Player 2" && collision.gameObject.CompareTag("Collectibles"))
        {
            Destroy(collision.gameObject);
            ScoreTwo++;
            Debug.Log(ScoreTwo);
        }
    }

    //public void Update()
    //{

    //}
}

