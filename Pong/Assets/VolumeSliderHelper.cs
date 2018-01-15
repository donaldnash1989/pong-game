using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderHelper : MonoBehaviour {

    private bool runOnce = false;
	
	void Update ()
    {
        Slider volumeSlider = GetComponent<Slider>();
        if (!runOnce)
        {
            GetComponent<Slider>().value = AudioManager.SFXVolume;
            runOnce = true;
        }
        volumeSlider.onValueChanged.AddListener(delegate { AudioManager.BGMValuChanged(volumeSlider.value); });
        volumeSlider.onValueChanged.AddListener(delegate { AudioManager.SFXValuChanged(volumeSlider.value); });
    }

    public void SaveSettings()
    {
        Slider volumeSlider = GetComponent<Slider>();
        PlayerPrefs.SetFloat("BGM", volumeSlider.value);
        PlayerPrefs.SetFloat("SFX", volumeSlider.value);
    }
}
