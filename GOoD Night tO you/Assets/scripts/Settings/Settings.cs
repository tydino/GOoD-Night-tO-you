using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour//original by brackeys
{
    public static Settings current;
    public PlayerCam playercam;
    public AudioMixer audioMixer;

    public Dropdown resolutionDropdown;

    Resolution[] resolutions;

    void Start(){
        current = this;
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i=0;i<resolutions.Length;i++){
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height){
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetMainVolume(float volume){
        audioMixer.SetFloat("volume", volume);
    }
    public void SetAmbienceVolume(float volume){
        audioMixer.SetFloat("volumeAmbience", volume);
    }
    public void SetLyricsVolume(float volume){
        audioMixer.SetFloat("volumeLyrics", volume);
    }
    public void SetMusicVolume(float volume){
        audioMixer.SetFloat("volumeMusic", volume);
    }
    public void SetVocalsVolume(float volume){
        audioMixer.SetFloat("volumeVocals", volume);
    }
    public void SetOtherVolume(float volume){
        audioMixer.SetFloat("volumeOther", volume);
    }

    public void SetQuality(int qualityIndex){
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetResolution(int resolutionIndex){
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetFullscreen(bool isFullscreen){
        Screen.fullScreen = isFullscreen;
    }
}
