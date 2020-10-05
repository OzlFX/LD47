using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer m_AudioMixer;
    public TMPro.TMP_Dropdown m_ResolutionDropdown;

    Resolution[] m_Resolutions;

    void Start()
    {
        m_Resolutions = Screen.resolutions;
        m_ResolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentRes = 0;
        for (int i = 0; i < m_Resolutions.Length; i++)
        {
            string option = m_Resolutions[i].width + " x " + m_Resolutions[i].height;
            options.Add(option);

            if (m_Resolutions[i].width == Screen.currentResolution.width && 
                m_Resolutions[i].height == Screen.currentResolution.height)
            {
                currentRes = i;
            }
        }

        m_ResolutionDropdown.AddOptions(options);
        m_ResolutionDropdown.value = currentRes;
        m_ResolutionDropdown.RefreshShownValue();
    }

    //Set the game volume
    public void SetVolume(float _volume)
    {
        m_AudioMixer.SetFloat("Volume", _volume);
    }

    //Set the quality settings
    public void SetQuality(int _quality)
    {
        QualitySettings.SetQualityLevel(_quality);
    }

    //Set window to fullscreen
    public void SetFullscreen(bool _isFullscreen)
    {
        Screen.fullScreen = _isFullscreen;
    }

    //Set resolution
    public void SetResolution(int _resolution)
    {
        Resolution resoultion = m_Resolutions[_resolution];
        Screen.SetResolution(resoultion.width, resoultion.height, Screen.fullScreen);
    }
}
