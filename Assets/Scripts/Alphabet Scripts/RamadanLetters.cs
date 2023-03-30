using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class RamadanLetters : MonoBehaviour
{
    public int buttonCounter = 0;
    public GameObject winPanel;
    public Button[] buttons;
    //public TextMeshProUGUI[] texts;
    public AudioSource joy;
    
    private void Start()
    {
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => { ButtonPressed(button); });
        }
    }
    IEnumerator Win()
    {
        yield return new WaitForSeconds(0.5f);
        joy.Play();
        winPanel.SetActive(true);
        
    }

    public void ButtonPressed(Button button)
    {
        if (button.interactable)
        {
            buttonCounter++;
            button.interactable = false;

            Color myColor = new Color32(0, 195, 16, 255);
            TextMeshProUGUI text = button.GetComponentInChildren<TextMeshProUGUI>();
            text.color = myColor;

            if (buttonCounter >= buttons.Length)
            {
                StartCoroutine(Win());
            }
        }
    }
    //public void ButtonPressed(Button button)
    //{
    //    if (button.interactable)
    //    {
    //        buttonCounter++;
    //        button.interactable = false;
    //        letterScore += 50;
    //        letterScoreText.text = letterScore.ToString();

    //        if (buttonCounter >= buttons.Length)
    //        {
    //            StartCoroutine(Win());
    //        } 
    //    }
    //}
    public void ResetGame()
    {
        buttonCounter = 0;
        foreach (Button button in buttons)
        {
            button.interactable = true;
            Color myColor = new Color32(0, 97, 203, 255);
            TextMeshProUGUI text = button.GetComponentInChildren<TextMeshProUGUI>();
            text.color = myColor;
        }
        winPanel.SetActive(false);
    }
    
}
