using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MamaKabiSlider : MonoBehaviour
{

    public GameObject finishPanel;
    int generalScore;
    public TextMeshProUGUI scoreText;
  
    private void Start()
    {
        generalScore = 0;
      
    }



    public void FinishPanelSetActive()
    {
        finishPanel.SetActive(true);
        PlayerPrefs.SetInt("counter", 0);
       
    }
    
    public void ScoreControl(int score)
    {
        generalScore += score;
        scoreText.text = generalScore.ToString();
    }
}