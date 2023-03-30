using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MarbleSenderRotation : MonoBehaviour
{
    public MarbleCountControl script;
    public GameObject[] marbles;
    public GameObject[] senderMarbles;
    public GameObject[] backPos;
    float speed = 370f;
    bool isMovement;
    public GameObject finishPanel;
    Vector3[] initialMarblesPositions;
    int score;
    public void Awake()
    {
        score = 0;
        initialMarblesPositions = new Vector3[marbles.Length];
        for (int i = 0; i < marbles.Length; i++)
        {
            initialMarblesPositions[i] = marbles[i].transform.position;
        }
        isMovement = false;
    }
    private void Update()
    {
        Movement();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == collision.gameObject.tag)
        {
            if (collision.gameObject.name == "20")
            {
                score += 30;
            }
            else if (collision.gameObject.name == "30")
            {
                score += 40;
            }
            else if (collision.gameObject.name == "10")
            {
                score += 20;
            }
            else
            {
                score += 20;
            }
            script.TotalScore(score);
            
            collision.gameObject.SetActive(false);
            gameObject.SetActive(false);
            script.Down();
        }
        else
        {
            gameObject.GetComponent<Button>().enabled = true;
            //gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("MarblePool").transform);
            Destroy(gameObject.GetComponent<MarbleSenderRotation>());
            script.Up();
        }
        script.ScoreCheck();
        script.isMovement = false;
        script.check = true;
        script.MarbleControl();
        script.OpenTrigger();
        CheckDistance();
    }

    public void Marbel()
    {
        script.sounds[1].Play();
    }
    public void CheckDistance()
    {
        float distance;
        distance = Vector3.Distance(gameObject.transform.position, script.triggerObject.transform.position);
        if (distance < 50)
        {
            finishPanel.SetActive(true);
        }
    }
    private void Movement()
    {
        isMovement = script.MovementSituation();
        if (isMovement)
        {
            transform.position = Vector3.MoveTowards(transform.position, script.TargetLocation(), speed * Time.deltaTime);
            transform.Rotate(0, 0, 5);
            script.CloseTrigger();
        }
    }
    public void ResetMarble()
    {
        isMovement = false;
        for (int i = 0; i < marbles.Length; i++)
        {
            marbles[i].SetActive(false);
        }
        for (int i = 0; i < backPos.Length; i++)
        {
            marbles[i].SetActive(true);
            marbles[i].transform.position = backPos[i].transform.position;
        }
        for (int i = 0; i < script.senderControl; i++)
        {
            senderMarbles[i].SetActive(false);
        }
        script.ScoreReset(0);
        script.counterMarble = 10;
    }
}