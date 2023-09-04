using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class settingsMenu : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;
    void Start()
    {
        if(PlayerPrefs.HasKey("VolumSalvat"))
        {
            LoadVolume();
        }
        else
        {
            ReglareVolum();
        }
    }
        public void ReglareVolum()
    {
        float volume = slider.value;
        mixer.SetFloat("Volume", volume);
        PlayerPrefs.SetFloat("VolumSalvat", volume);
    }

    void LoadVolume()
    {
        slider.value = PlayerPrefs.GetFloat("VolumSalvat");
        ReglareVolum();
    }
}
