using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SoundManagement;

public class Coin : MonoBehaviour
{
    [SerializeField] AudioClip coinPickupSound;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player") {

            SoundManager.Instance.PlaySound(coinPickupSound);
            ScoreManager.Instance.AddPointToScore();

            Destroy(gameObject);
        }
    }
}
