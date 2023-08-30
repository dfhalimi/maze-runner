using UnityEngine;

namespace SoundManagement
{
    public class SoundObject
    {
        public GameObject gameObject;
        public AudioSource audioSource;

        public SoundObject(GameObject gameObject, AudioSource audioSource)
        {
            this.gameObject = gameObject;
            this.audioSource = audioSource;
        }   
    }
}
