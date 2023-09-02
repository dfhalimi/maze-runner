using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagement : MonoBehaviour
{
    public static UIManagement Instance;

    [SerializeField] private Canvas _pauseScreen;
    [SerializeField] private Canvas _soundSettingsScreen;
    [SerializeField] private Canvas _gameOverScreen;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _pauseScreen.enabled = false;
        _soundSettingsScreen.enabled = false;
        _gameOverScreen.enabled = false;
    }

    public void EnablePauseScreen()
    {
        if (!_soundSettingsScreen.enabled) {
            _pauseScreen.enabled = true;
        }
    }

    public void ToggleSoundSettingsScreenFromPauseScreen()
    {
        if (_pauseScreen.enabled) {
            DisablePauseScreen();
            EnableSoundSettingsScreen();
        } else {
            DisableSoundSettingsScreen();
            EnablePauseScreen();
        }
    }

    public void ToggleSoundSettingsScreenFromMainMenuScreen()
    {
        if (_soundSettingsScreen.enabled) {
            DisableSoundSettingsScreen();
        } else {
            EnableSoundSettingsScreen();
        }
    }

    public void DisablePauseScreen()
    {
        _pauseScreen.enabled = false;
        _soundSettingsScreen.enabled = false;
    }

    public void EnableSoundSettingsScreen()
    {
        _soundSettingsScreen.enabled = true;
    }

    public void DisableSoundSettingsScreen()
    {
        _soundSettingsScreen.enabled = false;
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
