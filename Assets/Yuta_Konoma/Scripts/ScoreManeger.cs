using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManeger : SingletonMonoBehaviour<ScoreManeger>
{
    public float Score => _score;
    
    public float _score;

    [SerializeField] TextMeshProUGUI _scoreText;
    private void Start()
    {
        _scoreText.text = "Score:" + _score;
    }
    public void GameOver()
    {
        _score = _score * Timer._time;
        _score = (float)Math.Floor(_score);
    }
}
