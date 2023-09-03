using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    [SerializeField] private Canvas _canvas;

    private string _canvasName;

    private void Awake()
    {
        if (_canvas != null) {
            _canvasName = _canvas.gameObject.name;
            RegisterWithUIManager();
        }
    }

    public void RegisterWithUIManager()
    {
        UIManager.Instance.RegisterScreen(_canvasName, this);
    }

    public void UnregisterWithUIManager()
    {
        UIManager.Instance.UnregisterScreen(_canvasName);
    }

    public void ShowScreen()
    {
        _canvas.enabled = true;
    }

    public void HideScreen()
    {
        _canvas.enabled = false;
    }
}
