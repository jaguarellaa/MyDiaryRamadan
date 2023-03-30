using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrumSliderControl : MonoBehaviour
{
    public Image sliderIn;
    public GameObject finishPanel;

    private void Start()
    {
        InvokeRepeating("Slider", 0.1f, 0.05f);
    }
    

    public void Slider()
    {
        sliderIn.fillAmount -= 0.001f;
        if (sliderIn.fillAmount == 0)
        {
            finishPanel.SetActive(true);
        }
    }
}
