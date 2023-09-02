using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoundManagement
{
    public class SoundTrackManager : MonoBehaviour
    {
        private AudioSource _soundTrack;
        private float _soundTrackVolume;

        private void Awake()
        {
            _soundTrack = GetComponent<AudioSource>();
        }

        private void Start()
        {
            if (_soundTrack != null && _soundTrack.clip != null) {
                _soundTrackVolume = _soundTrack.volume;
                _soundTrack.volume = (SoundSettingsManager.Instance.BackgroundMusicVolumeSliderValue / 100);
                _soundTrack.Play();
            }
        }

        private void Update()
        {
            _soundTrack.volume = _soundTrackVolume * (SoundSettingsManager.Instance.BackgroundMusicVolumeSliderValue / 100);
        }
    }
}
