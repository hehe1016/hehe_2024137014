using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioMixerController : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;        //private 선언한 것들을 인스팩터 창에서 보여지게
    [SerializeField] private Slider MusicMasterSlider;       //UI Slider
    [SerializeField] private Slider MusicBGMSlider;        //UI Slider
    [SerializeField] private Slider MusicSFXSlider;        //UI Slider
    //슬라이더 Minvalue을 0.001

    private void Awake()
    {
        MusicMasterSlider.onValueChanged.AddListener(SetMasterVolume);
        MusicBGMSlider.onValueChanged.AddListener(SetBGMVolume);
        MusicSFXSlider.onValueChanged.AddListener(SetSFXVolume);
    }
    public void SetMasterVolume(float volume)
    {
        audioMixer.SetFloat("Master", Mathf.Log10(volume) * 20);   //볼륨에서의 0~1 <- Mathf.Log10(volume) *20
    }

    public void SetBGMVolume(float volume)
    {
        audioMixer.SetFloat("BGM", Mathf.Log10(volume) * 20);     //볼륨에서의 0~1 <- Mathf.Log10(volume) *20
    }

    public void SetSFXVolume(float volume)
    {
        audioMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);     //볼륨에서의 0~1 <- Mathf.Log10(volume) *20
    }
}
