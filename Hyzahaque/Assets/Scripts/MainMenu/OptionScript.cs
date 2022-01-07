using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionScript : MonoBehaviour
{
    public AudioMixer audioMixer;
    public AudioMixer audioSFXMixer;

    public GameObject optionWindow;
    public GameObject mainMenuWindow;


    public void SetVolume(float volume)
    {
        Debug.Log(volume);
        audioMixer.SetFloat("volume", volume);
    }
    
    
    public void SetSFXVolume(float SFXvolume)
    {
        Debug.Log(SFXvolume);
        audioSFXMixer.SetFloat("volume", SFXvolume);
    }


    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }


    public void CloseOptions()
    {
        optionWindow.SetActive(false);
        Debug.Log("option closed");
    }

    public void openMainMenuWindow()
    {
        mainMenuWindow.SetActive(true);
        Debug.Log("mainMenu opened");
    }



}
