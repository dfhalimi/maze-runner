using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool IsLocked { get; private set; } = true;
    
    private void Start()
    {
        Key key = FindObjectOfType<Key>();
        if (key != null) {
            key.KeyCollected += UnlockDoor;
        }
    }

    private void UnlockDoor()
    {
        IsLocked = false;
    }
}
