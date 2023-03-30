using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameButtonManager : MonoBehaviour
{
    public List<GameObject> gamePanelList;
    public GameObject canvas;
    public GameObject canvas30;
    
    public ReturnCalendar retC;

    public AudioSource click;
    public AudioSource dayClick;

    public GameObject bgSoundButton;
    public SoundCont soundMan;
    public AudioSource bg;
    public Image[] soundImage;
    



    public void GameSoundStop()
    {
       ;

        if (GameManger.gameManger.activeGameIndeks==1|| GameManger.gameManger.activeGameIndeks == 4|| GameManger.gameManger.activeGameIndeks == 7|| GameManger.gameManger.activeGameIndeks == 9
           || GameManger.gameManger.activeGameIndeks == 11| GameManger.gameManger.activeGameIndeks == 14|| GameManger.gameManger.activeGameIndeks == 15|| GameManger.gameManger.activeGameIndeks == 19|| GameManger.gameManger.activeGameIndeks == 20|| GameManger.gameManger.activeGameIndeks == 24)

        {

            
            bg.Stop();
            bgSoundButton.SetActive(false);
        }
        else
        {  
            bg.volume=0.15f;
        }
       


    }
    public void GameSoundPlay()
    {   
        if(soundMan.muted ==false)
        {
            bg.Play();
            bg.volume = 0.28f;
            bgSoundButton.SetActive(true);
            soundImage[0].enabled = true;
            soundImage[1].enabled = false;

        }
        else
        {
            bg.Stop();
            bg.volume = 0.28f;
            bgSoundButton.SetActive(true);
            soundImage[0].enabled = false;
            soundImage[1].enabled = true;
        }
    



    }



    public void HideGamePanel()
    {
        foreach(var item in gamePanelList )
        {
            item.SetActive(false);

        }
    }

    public void GameButtonSound()
    {
        click.Play();
    }

    public void DayuttonSound()
    {
       dayClick.Play();
    }



    public void gameBtnFonc()
    {
        if(GameManger.gameManger.activeGameIndeks!=29)
        {
            HideGamePanel();
            gamePanelList[GameManger.gameManger.activeGameIndeks].SetActive(true);
        }
        else
        {

            canvas.SetActive(false);
           
            
            canvas30.SetActive(true);
        }
       

    }

    public void AppExit()
    {
        Application.Quit();
    }

}
