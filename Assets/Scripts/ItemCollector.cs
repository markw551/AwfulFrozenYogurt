using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectibles"))
        {
            Destroy(collision.gameObject);
        }
    }
}

//{
//    public int score = 0;
    
//    public class Collector
//    {
//        public int FruitValue;
//        public bool Collider; 

//        public Collector(int fruitvalue, bool collider)
//        {
//            this.FruitValue = fruitvalue;
//            this.Collider = collider;
//        }
//    }

//    void Start()
//    {
//        Collector Player = new Collector(5, true);
//        Player
//    }

//    void Update()
//    {
//        if (collider && gameObject.CompareTag("Collectibles"))
//        {
//            // Do something when colliding with a collectible
//            Debug.Log("Player collected a collectible!");
//            Destroy(gameObject);
//            score += FruitValue;
//        }
//    }
//}
