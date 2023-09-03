using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public const string MAIN_MENU_SCREEN_NAME = "MainMenuScreen";
    public const string PAUSE_SCREEN_NAME = "PauseScreen";
    public const string GAME_OVER_SCREEN_NAME = "GameOverScreen";
    public const string SETTINGS_SCREEN_NAME = "SettingsScreen";

    public static UIManager Instance;

    private Dictionary<string, ScreenManager> _screenManagers = new Dictionary<string, ScreenManager>();

    private void Awake()
    {
        Instance = this;
    }

    public void RegisterScreen(string screenName, ScreenManager screenManager)
    {
        if (!_screenManagers.ContainsKey(screenName)) {
            _screenManagers.Add(screenName, screenManager);
        }
    }

    public void UnregisterScreen(string screenName)
    {
        if (_screenManagers.ContainsKey(screenName)) {
            _screenManagers.Remove(screenName);
        }
    }

    public void ShowSettingsScreenViaMainMenu()
    {
        HideScreen(MAIN_MENU_SCREEN_NAME);
        ShowScreen(SETTINGS_SCREEN_NAME);
    }

    public void ReturnToMainMenuScreenViaSettings()
    {
        HideScreen(SETTINGS_SCREEN_NAME);
        ShowScreen(MAIN_MENU_SCREEN_NAME);
    }

    public void ShowSettingsScreenViaPauseMenu()
    {
        HideScreen(PAUSE_SCREEN_NAME);
        ShowScreen(SETTINGS_SCREEN_NAME);
    }

    public void ReturnToPauseScreenViaSettings()
    {
        HideScreen(SETTINGS_SCREEN_NAME);
        ShowScreen(PAUSE_SCREEN_NAME);
    }

    public void ShowScreen(string screenName)
    {
        if (_screenManagers.TryGetValue(screenName, out ScreenManager screenManager)) {
            screenManager.ShowScreen();
        }
    }

    public void HideScreen(string screenName)
    {
        if (_screenManagers.TryGetValue(screenName, out ScreenManager screenManager)) {
            screenManager.HideScreen();
        }
    }
}
