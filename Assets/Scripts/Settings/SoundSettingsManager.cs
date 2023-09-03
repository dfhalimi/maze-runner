using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SoundSettingsManager : MonoBehaviour
{
    const string BACKGROUND_MUSIC_VOLUME_SLIDER_VALUE = "backgroundMusicVolumeSliderValue";
    const string SOUND_EFFECTS_VOLUME_SLIDER_VALUE = "soundEffectsVolumeSliderValue";

    public static SoundSettingsManager Instance;
    public float BackgroundMusicVolumeSliderValue { get; private set; } = 100.0f;
    public float SoundEffectsVolumeSliderValue { get; private set; } = 100.0f;

    [SerializeField] private Slider _backgroundMusicVolumeSlider;
    [SerializeField] private Slider _soundEffectsVolumeSlider;
    [SerializeField] private TextMeshProUGUI _backgroundMusicVolumeSliderValueText;
    [SerializeField] private TextMeshProUGUI _soundEffectsVolumeSliderValueText;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        BackgroundMusicVolumeSliderValue = PlayerPrefs.GetFloat(BACKGROUND_MUSIC_VOLUME_SLIDER_VALUE, 100.0f);
        SoundEffectsVolumeSliderValue = PlayerPrefs.GetFloat(SOUND_EFFECTS_VOLUME_SLIDER_VALUE, 100.0f);

        _backgroundMusicVolumeSlider.value = BackgroundMusicVolumeSliderValue;
        _soundEffectsVolumeSlider.value = SoundEffectsVolumeSliderValue;

        _backgroundMusicVolumeSliderValueText.text = BackgroundMusicVolumeSliderValue.ToString();
        _soundEffectsVolumeSliderValueText.text = SoundEffectsVolumeSliderValue.ToString();
    }

    public void UpdateSliderValue()
    {
        if (BackgroundMusicVolumeSliderValue != _backgroundMusicVolumeSlider.value) {
            BackgroundMusicVolumeSliderValue = _backgroundMusicVolumeSlider.value;
            _backgroundMusicVolumeSliderValueText.text = BackgroundMusicVolumeSliderValue.ToString();
        }
        if (SoundEffectsVolumeSliderValue != _soundEffectsVolumeSlider.value) {
            SoundEffectsVolumeSliderValue = _soundEffectsVolumeSlider.value;
            _soundEffectsVolumeSliderValueText.text = SoundEffectsVolumeSliderValue.ToString();
        }
    }

    public void SaveSettingsAndReturnToPauseScreen()
    {
        SaveSoundSettings();
        UIManager.Instance.ReturnToPauseScreenViaSettings();
    }

    public void SaveSettingsAndReturnToMainMenuScreen()
    {
        SaveSoundSettings();
        UIManager.Instance.ReturnToMainMenuScreenViaSettings();
    }

    private void SaveSoundSettings()
    {
        float lastSavedBMusicVolumeSliderValue = PlayerPrefs.GetFloat(BACKGROUND_MUSIC_VOLUME_SLIDER_VALUE, 100.0f);
        float lastSavedSEVolumeSliderValue = PlayerPrefs.GetFloat(SOUND_EFFECTS_VOLUME_SLIDER_VALUE, 100.0f);

        if (lastSavedBMusicVolumeSliderValue != BackgroundMusicVolumeSliderValue) {
            PlayerPrefs.SetFloat(BACKGROUND_MUSIC_VOLUME_SLIDER_VALUE, BackgroundMusicVolumeSliderValue);
        }
        if (lastSavedSEVolumeSliderValue != SoundEffectsVolumeSliderValue) {
            PlayerPrefs.SetFloat(SOUND_EFFECTS_VOLUME_SLIDER_VALUE, SoundEffectsVolumeSliderValue);
        }
    }
}
