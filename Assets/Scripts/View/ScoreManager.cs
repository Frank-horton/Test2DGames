using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public  TextMeshProUGUI _highScoreText;
    public  TextMeshProUGUI _scoreText;
    public  TextMeshProUGUI Point;
    public  TextMeshProUGUI Life;

    public static int _highScoreCount;
    public static int ScoreCount;
    public static int PointCountView;
    public static int LifeCountView;
    
    private void Start()
    {
        ScoreCount = 0;
        LifeCountView = 5;
    }

    private void Update()
    {
        SaveScore();
        ConvertScore();
    }

    public void SaveScore()
    {
        if (PlayerPrefs.GetInt("score") <= _highScoreCount)
        {
            PlayerPrefs.SetInt("score", _highScoreCount);
        }
        _highScoreText.text = "HighScore: " + PlayerPrefs.GetInt("score".ToString());
    }

    private void ConvertScore()
    {
        _highScoreCount = (int)ScoreCount;
        _scoreText.text = "Score: " + _highScoreCount.ToString();

        Point.text = "Point: " + PointCountView;
        Life.text = "Life: " + LifeCountView;
    }
}