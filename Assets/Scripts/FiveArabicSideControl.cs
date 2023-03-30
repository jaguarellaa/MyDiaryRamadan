using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FiveArabicSideControl : MonoBehaviour
{
    public Image[] sentenceImages;
    int counter;
    public float speed1;
    public float speed2;
    public float speed3;
    public float speed4;
    public GameObject controlButton;
    int buttonController;
    public GameObject readingPanel;
    public GameObject matchButton;
    public GameObject exitButton;


    public void Start()
    {
    }
    public void FillSentence()
    {
        switch (counter)
        {
            case 0:
                sentenceImages[0].fillAmount += speed1;
                if (sentenceImages[0].fillAmount >= 1)
                {
                    counter++;
                }
                break;
            case 1:
                sentenceImages[1].fillAmount += speed2;
                if (sentenceImages[1].fillAmount >= 1)
                {
                    counter++;
                }
                break;
            case 2:
                sentenceImages[2].fillAmount += speed3;
                if (sentenceImages[2].fillAmount >= 1)
                {
                    counter++;
                }
                break;
            case 3:
                sentenceImages[3].fillAmount += speed4;
                if (sentenceImages[3].fillAmount >= 1)
                {
                    counter++;
                    //CancelInvoke();
                    //textCounter++;
                }
                break;
            //case 5:
            //    sentenceImages[5].fillAmount += 0.030f;
            //    if (sentenceImages[5].fillAmount >= 1)
            //    {
            //        counter = 0;
            //    }
            //    break;
            default:
                controlButton.SetActive(true);
                matchButton.SetActive(true);
                buttonController++;
                CancelInvoke();
                break;
        }
    }
    public void Match()
    {
        readingPanel.SetActive(false);
        exitButton.SetActive(true);
    }
    public void CloseExitButton()
    {
        exitButton.SetActive(false);
    }
    public void Invo()
    {
        if (buttonController > 4)
        {
            GetStartPosition();
            readingPanel.SetActive(false);
            buttonController = 0;
        }
        else
        {
            controlButton.SetActive(false);
            counter = 0;
            InvokeRepeating("FillSentence", 0.1f, 0.1f);
        }
        
    }
    public void GetStartPosition()
    {
        for (int i = 0; i < sentenceImages.Length; i++)
        {
            sentenceImages[i].fillAmount = 0;
        }
        matchButton.SetActive(false);
    }
    public void Restart()
    {
        GetStartPosition();
        CancelInvoke();
    }

}

