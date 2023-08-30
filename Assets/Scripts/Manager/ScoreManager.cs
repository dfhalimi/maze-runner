using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    const string HIGHSCORE = "highscore";

    public static ScoreManager Instance;

    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private TextMeshProUGUI _highscoreText;

    private int _score = 0;
    private int _highscore = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _highscore = PlayerPrefs.GetInt(HIGHSCORE, 0);

        _scoreText.text = "Score: " + _score.ToString();
        _highscoreText.text = "Highscore: " + _highscore.ToString();
    }

    public void AddPointToScore()
    {
        _score += 1;
        _scoreText.text = "Score: " + _score.ToString();

        if (_highscore < _score) {
            PlayerPrefs.SetInt(HIGHSCORE, _score);
        }
    }
}
