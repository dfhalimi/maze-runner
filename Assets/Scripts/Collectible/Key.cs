using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public event Action KeyCollected;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player") {
            OnKeyCollected();
            Destroy(gameObject);
        }
    }

    public void OnKeyCollected()
    {
        KeyCollected?.Invoke();
    }
}
