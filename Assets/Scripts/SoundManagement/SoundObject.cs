using UnityEngine;

namespace SoundManagement
{
    public class SoundObject
    {
        public GameObject GameObject;
        public AudioSource AudioSource;

        public SoundObject(GameObject gameObject, AudioSource audioSource)
        {
            this.GameObject = gameObject;
            this.AudioSource = audioSource;
        }   
    }
}
