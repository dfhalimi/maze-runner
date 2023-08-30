using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerHandler : MonoBehaviour
{
    [SerializeField] private Door _door;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player") {
            if (!_door.IsLocked) {
                Destroy(_door.gameObject);
            }
        }
    }
}
