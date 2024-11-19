using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour//original by brackeys
{
    public AudioMixer audioMixer;

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
}
