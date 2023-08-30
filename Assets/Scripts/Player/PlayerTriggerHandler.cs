using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggerHandler : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        if (   collider.gameObject.tag == "Wall"
            || collider.gameObject.tag == "Enemy"
        ) {
            LevelManagement.Instance.LoseLevel();
        }

        if (collider.gameObject.tag == "Finish") {
            LevelManagement.Instance.WinLevel();
        }
    }
}
