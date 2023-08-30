using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoundManagement
{
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager Instance;

        private void Awake()
        {
            Instance = this;
        }

        public void PlaySound(AudioClip audioClip)
        {
            var soundObject = CreateTemporarySoundObject(audioClip);
            soundObject.audioSource.Play();

            Destroy(soundObject.gameObject, audioClip.length);
        }

        private SoundObject CreateTemporarySoundObject(AudioClip audioClip)
        {
            GameObject soundGameObject = new GameObject("TemporarySound");
            AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();

            audioSource.clip = audioClip;

            return new SoundObject(soundGameObject, audioSource);
        }
    }
}
