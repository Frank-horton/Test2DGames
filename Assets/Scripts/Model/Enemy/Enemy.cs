using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject PanelGameOver;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ScoreManager.LifeCountView--;

            if (ScoreManager.LifeCountView <= 0)
            {
                Destroy(collision.gameObject);
                PanelGameOver.SetActive(true);
            }
        }
    }
}