using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundCont : MonoBehaviour
{
    public Image soundOn;
    public Image soundOff;



    public AudioSource bg;
    public bool muted = false;

    public bool control;


    private void Start()
    {   

        
        if(!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
            
                
        }

        UpdateButton();

        bg.Play();
        soundOn.enabled = true;
        soundOff.enabled = false;




    }

    public void OnButtonPress()
    {
        if(muted==false)
        {
            muted = true;
            //AudioListener.pause = true;
            soundOn.enabled = false;
            soundOff.enabled = true;
            bg.Pause();
        }
        else
        {
            muted = false;
            //AudioListener.pause = false;
            soundOn.enabled = true;
            soundOff.enabled = false;
            bg.Play();
        }
        Save();
        UpdateButton();
    }

    private void UpdateButton()
    {

        if(muted==false)
        {
            soundOn.enabled = true;
            soundOff.enabled = false;
          
        }
        else
        {

            soundOn.enabled =false;
            soundOff.enabled = true;
           

        }

     
    }

    private void Load()
    {
        muted=PlayerPrefs.GetInt("muted") ==1 ;
    }


    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
  
}
