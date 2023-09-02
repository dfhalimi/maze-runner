using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoundManagement
{
    public class SoundTrackManager : MonoBehaviour
    {
        private AudioSource _soundTrack;

        void Awake()
        {
            _soundTrack = GetComponent<AudioSource>();
        }

        void Start()
        {
            if (_soundTrack != null && _soundTrack.audioClip != null) {
                _soundTrack.Play();
            }
        }
    }
}
