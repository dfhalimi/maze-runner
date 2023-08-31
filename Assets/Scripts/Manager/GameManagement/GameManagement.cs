using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public static GameManagement Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        if (PauseManagement.Instance.IsPaused || LevelManagement.Instance.IsGameOver) {
            Application.Quit();
        }
    }

    public void QuitGameFromMainMenu()
    {
        Application.Quit();
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ReturnToMainMenuFromPauseOrGameOverScreen()
    {
        if (PauseManagement.Instance.IsPaused || LevelManagement.Instance.IsGameOver) {
            ReturnToMainMenu();
        }
    }
}
