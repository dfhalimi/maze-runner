using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoundManagement
{
    public class SoundTrackManager : MonoBehaviour
    {
        [SerializeField] AudioSource _soundTrack;

        void Start()
        {
            if (_soundTrack != null) {
                _soundTrack.Play();
            }
        }
    }
}
