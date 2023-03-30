using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BimeceTimer : MonoBehaviour
{
    public Image timer;
    public GameObject finishPanel;
    public bool check;

    public void Start()
    {
        check = true;
        InvokeRepeating("TimerControl", 0.0001f, 0.0001f);
    }
    public void TimerControl()
    {
        if (check)
        {
            timer.fillAmount -= 0.00005f;
            if (timer.fillAmount == 0)
            {
                finishPanel.SetActive(true);
            }
        }

    }

}
