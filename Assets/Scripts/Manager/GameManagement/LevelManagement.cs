using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagement : MonoBehaviour
{
    public bool IsGameOver { get; private set; } = false;

    public static LevelManagement Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void WinLevel()
    {
        if (!IsGameOver) {
            IsGameOver = true;
            TimeManipulation.Instance.StopTimeScale();
            SceneManager.LoadScene("EndScreen");
        }
    }

    public void LoseLevel()
    {
        if (!IsGameOver) {
            IsGameOver = true;
            TimeManipulation.Instance.StopTimeScale();
            UIManagement.Instance.EnableGameOverScreen();
        }
    }

    public void RestartLevel()
    {
        if (PauseManagement.Instance.IsPaused || IsGameOver) {
            TimeManipulation.Instance.ResumeTimeScale();
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
