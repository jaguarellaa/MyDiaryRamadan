using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarbleTimer : MonoBehaviour
{
    public Image timer;
    private float maxTime = 30f;
    public GameObject finishPanel;
    public AudioSource finishPanelSound;
    bool panelCheck;
    float timeLeft;
    
    public void Start()
    {
        timer.GetComponent<Image>();
        timeLeft = maxTime;
        panelCheck = true;
        
        //InvokeRepeating("TimerCounter", 0.001f, 0.001f);
    }


    private void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timer.fillAmount = timeLeft / maxTime;

        }
        else
        {
            if (panelCheck)
            {
                finishPanelSound.Play();
                panelCheck = false;
            }
            finishPanel.SetActive(true);
        }
    }
    
    //public void TimerCounter()
    //{    
    //    timer.fillAmount -= 0.0001f;       
    //    if(timer.fillAmount == 0 )
    //    {
    //        finishPanel.SetActive(true);
    //        finishPanelSound.Play();
    //        CancelInvoke();
    //    }
    //}
    public void Reset()
    {
        timer.GetComponent<Image>();
        timeLeft = maxTime;
        panelCheck = true;
        //timer.fillAmount = 1;
        //InvokeRepeating("TimerCounter", 0.001f, 0.001f);
    }

    public void CancelTimerCounter()
    {
        CancelInvoke();
    }
}
