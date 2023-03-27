using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public Toggle full, vsynk;

    public AudioMixer theMixer;

    public Slider masters, musics, sfxs;
    public Text mastert, musict, sfxt;
    
    
    // Start is called before the first frame update
    void Start()
    {
        

        if(QualitySettings.vSyncCount == 0)
        {
            vsynk.isOn = false;
        }
        else
        {
            vsynk.isOn = true;
        }

        if (PlayerPrefs.HasKey("MasterVol"))
        {
            theMixer.SetFloat("MasterVol", PlayerPrefs.GetFloat("MasterVol"));
            masters.value = PlayerPrefs.GetFloat("MasterVol");
            mastert.text = (masters.value + 80).ToString();
        }

        if (PlayerPrefs.HasKey("MusicVol"))
        {
            theMixer.SetFloat("MusicVol", PlayerPrefs.GetFloat("MusicVol"));
            musics.value = PlayerPrefs.GetFloat("MusicVol");
            musict.text = (musics.value + 80).ToString();
        }

        if (PlayerPrefs.HasKey("MasterVol"))
        {
            theMixer.SetFloat("MasterVol", PlayerPrefs.GetFloat("MasterVol"));
            masters.value = PlayerPrefs.GetFloat("MasterVol");
            mastert.text = (masters.value + 80).ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApplyGraphics()
    {
        //apply full
        Screen.fullScreen = full.isOn;

        if (vsynk.isOn)
        {
            QualitySettings.vSyncCount = 1;
        }
        else
        {
            QualitySettings.vSyncCount = 0;
        }
    } 

    public void SetMasterVol()
    {
        mastert.text = (masters.value + 80).ToString();

        theMixer.SetFloat("MasterVol", masters.value);

        PlayerPrefs.SetFloat("MasterVol", masters.value);
    }

    public void SetMusicVol()
    {
        musict.text = (musics.value + 80).ToString();

        theMixer.SetFloat("MusicVol", musics.value);

        PlayerPrefs.SetFloat("MusicVol", musics.value);
    }

    public void SetSFXVol()
    {

        sfxt.text = (sfxs.value + 80).ToString();

        theMixer.SetFloat("SFXVol", sfxs.value);

        PlayerPrefs.SetFloat("SFXVol", sfxs.value);
    }
}
