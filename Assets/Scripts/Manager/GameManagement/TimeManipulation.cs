using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManipulation : MonoBehaviour
{
    public static TimeManipulation Instance;

    private float _previousTimeScale;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void StopTimeScale()
    {
        _previousTimeScale = Time.timeScale;
        Time.timeScale = 0;
    }

    public void ResumeTimeScale()
    {
        Time.timeScale = _previousTimeScale;
    }
}
