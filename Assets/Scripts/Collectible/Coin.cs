using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SoundManagement;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioClip _coinPickupSound;
    [SerializeField, Range(0, 1)] private float _soundEffectVolume;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player") {

            SoundEffectManager.Instance.PlaySound(_coinPickupSound, _soundEffectVolume);
            ScoreManager.Instance.AddPointToScore();

            Destroy(gameObject);
        }
    }
}
