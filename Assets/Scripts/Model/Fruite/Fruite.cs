using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruite : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ScoreManager.ScoreCount += 1;
            ScoreManager.PointCountView++;
            Destroy(gameObject);
        }
    }
}
