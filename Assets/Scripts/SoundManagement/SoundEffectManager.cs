using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoundManagement
{
    public class SoundEffectManager : MonoBehaviour
    {
        public static SoundEffectManager Instance;

        private void Awake()
        {
            Instance = this;
        }

        public void PlaySound(AudioClip audioClip, float volume = 1.0f)
        {
            var soundObject = CreateTemporarySoundObject(audioClip, volume);
            soundObject.AudioSource.Play();

            Destroy(soundObject.GameObject, audioClip.length);
        }

        private SoundObject CreateTemporarySoundObject(AudioClip audioClip, float volume = 1.0f)
        {
            GameObject soundGameObject = new GameObject("TemporarySound");
            AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();

            audioSource.clip = audioClip;
            audioSource.volume = volume;

            return new SoundObject(soundGameObject, audioSource);
        }
    }
}
