using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MarbleCountControl : MonoBehaviour
{
    public GameObject[] marbles;
    Vector2 targetLocation;
    int counter;
    string selectedItemNumber;
    public bool isMovement;
    public GameObject finishPanel;
    public GameObject triggerObject;
    public int counterMarble;
    public int senderControl;
    public TextMeshProUGUI scoreText;
    int scoreTotal;
    public bool check;
    public AudioSource[] sounds;
    private void Start()
    {
        counterMarble = 10;
    }
    private void Update()
    {
    }
    public void TotalScore(int score)
    {
        sounds[0].Play();
        scoreTotal += score;
        sounds[1].Play();
        scoreText.text = scoreTotal.ToString();
    }
    public void ScoreReset(int score)
    {
        scoreTotal = score;
        scoreText.text = scoreTotal.ToString();
    }
    public void MarbleControl()
    {
        if (check)
        {
            new WaitForSeconds(0.5f);
            sounds[1].Play();
            marbles[counter + 1].SetActive(true);
            counter++;
            senderControl++;
            check = false;
        }
    }
    public void WhichButton()
    {
        targetLocation = Input.mousePosition;
        isMovement = true;
    }
    public Vector2 TargetLocation()
    {
        return targetLocation;
    }
    public bool MovementSituation()
    {
        return isMovement;
    }
    public void ScoreCheck()
    {
        if (counterMarble == 0)
        {
            finishPanel.SetActive(true);
            sounds[2].Play();
        }
    }
    public void Up()
    {
        counterMarble++;
    }
    public void Down()
    {
        counterMarble--;
    }
    public void OpenTrigger()
    {
        triggerObject.SetActive(true);
    }
    public void CloseTrigger()
    {
        triggerObject.SetActive(false);
    }
}