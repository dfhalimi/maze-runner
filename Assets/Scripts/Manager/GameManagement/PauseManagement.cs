using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManagement : MonoBehaviour
{
    public static PauseManagement Instance;

    public bool IsPaused { get; private set; } = false;

    private void Awake()
    {
        Instance = this;
    }

    public void TogglePause()
    {
        if (!IsPaused) {
            PauseGame();
        } else if (IsPaused && !LevelManagement.Instance.IsGameOver) {
            ResumeGame();
        }
    }

    private void PauseGame()
    {
        if (!IsPaused && !LevelManagement.Instance.IsGameOver) {
            IsPaused = true;
            TimeManipulation.Instance.StopTimeScale();
            UIManagement.Instance.EnablePauseScreen();
        }
    }

    private void ResumeGame()
    {
        if (IsPaused && !LevelManagement.Instance.IsGameOver) {
            IsPaused = false;
            TimeManipulation.Instance.ResumeTimeScale();
            UIManagement.Instance.DisablePauseScreen();
        }
    }
}
