using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) {
            PauseManagement.Instance.TogglePause();
        }

        if (Input.GetKeyDown(KeyCode.R)) {
            LevelManagement.Instance.RestartLevel();
        }

        if (Input.GetKeyDown(KeyCode.Q)) {
            GameManagement.Instance.ReturnToMainMenuFromPauseOrGameOverScreen();
        }
    }
}
