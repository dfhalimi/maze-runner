using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerHandler : MonoBehaviour
{
    [SerializeField] private Door door;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player") {
            if (!door.IsLocked) {
                Destroy(door.gameObject);
            }
        }
    }
}
