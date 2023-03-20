using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    public int score = 0;

    private void OnTriggerEnter2D(PolygonCollider2D collision)
    {
        if (collision.CompareTag("Collectibles"))
        {
            score += 1;
            Destroy(collision.gameObject);
        }
    }
}
