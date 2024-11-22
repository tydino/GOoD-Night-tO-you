using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour//original by brackeys
{
    //things (to be)used in saving
    public static float volumeMasterFloat;
    public static float volumeMusicFloat;
    public static float volumeAmbienceFloat;
    public static float volumeVocalsFloat;
    public static float volumeLyricsFloat;
    public static float volumeOtherFloat;
    public static int resolutionInt;
    public static int QualityInt;
    public static bool FullscreenBool;
    public static Settings current;
    //other things
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
        volumeMasterFloat = volume;
    }
    public void SetAmbienceVolume(float volume){
        audioMixer.SetFloat("volumeAmbience", volume);
        volumeAmbienceFloat = volume;
    }
    public void SetLyricsVolume(float volume){
        audioMixer.SetFloat("volumeLyrics", volume);
        volumeLyricsFloat = volume;
    }
    public void SetMusicVolume(float volume){
        audioMixer.SetFloat("volumeMusic", volume);
        volumeMusicFloat = volume;
    }
    public void SetVocalsVolume(float volume){
        audioMixer.SetFloat("volumeVocals", volume);
        volumeVocalsFloat = volume;
    }
    public void SetOtherVolume(float volume){
        audioMixer.SetFloat("volumeOther", volume);
        volumeOtherFloat = volume;
    }

    public void SetQuality(int qualityIndex){
        QualitySettings.SetQualityLevel(qualityIndex);
        QualityInt = qualityIndex;
    }

    public void SetResolution(int resolutionIndex){
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
        resolutionInt = resolutionIndex;
    }

    public void SetFullscreen(bool isFullscreen){
        Screen.fullScreen = isFullscreen;
        FullscreenBool = isFullscreen;
    }
}
