using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AbdTimer : MonoBehaviour
{
    public TextMeshProUGUI point;
    public Image timer;
    public GameObject finishPanel;
 


    public void Start()
    {
        InvokeRepeating("TimerControl", 0.0001f, 0.0001f);
    }
    public void TimerControl()
    {
        timer.fillAmount -= 0.00001f;
        if(timer.fillAmount == 0)
        {
            finishPanel.SetActive(true);
            point.text = (PlayerPrefs.GetInt("abdCounter") * 100).ToString();
        }
    }
}
