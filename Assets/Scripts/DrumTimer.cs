using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DrumTimer : MonoBehaviour
{
    public Image timer;
    public GameObject finishPanel;
   

    public void Start()
    {
        InvokeRepeating("TimerControl",0.005f,0.005f);
    }

    public void  TimerControl()
    {
        timer.fillAmount -= 0.0001f;
        if(timer.fillAmount == 0)
        {
            finishPanel.SetActive(true);
            
        }
    }
}
