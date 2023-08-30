using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagement : MonoBehaviour
{
    public static UIManagement Instance;

    [SerializeField] private Canvas _pauseScreen;
    [SerializeField] private Canvas _gameOverScreen;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _pauseScreen.enabled = false;
        _gameOverScreen.enabled = false;
    }

    public void EnablePauseScreen()
    {
        _pauseScreen.enabled = true;
    }

    public void DisablePauseScreen()
    {
        _pauseScreen.enabled = false;
    }

    public void EnableGameOverScreen()
    {
        _gameOverScreen.enabled = true;
    }

    public void DisableGameOverScreen()
    {
        _gameOverScreen.enabled = false;
    }
}
