using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BilmeceMatch : MonoBehaviour
{
    [SerializeField] private Button[] bilmeceBtns;
    [SerializeField] private Button[] bilmeceAnswerBtns;
    [SerializeField] private GameObject[] arrowList;
    [SerializeField] private GameObject finishPanel;
   
    int buttonValue;
    int answerButtonValue;
    int counter;

    public void Start()
    {
        InputBilmece();
        InputAnswer();
    }


    public void InputBilmece()
    {
        foreach (Button btn in bilmeceBtns)
        {
            Button choice = btn;
            btn.onClick.AddListener(() => TaskOnClick(choice));
        }
    }

    public void InputAnswer()
    {
        foreach (Button btnAnswer in bilmeceAnswerBtns)
        {
            Button choiceAnswer = btnAnswer;
            btnAnswer.onClick.AddListener(() => TaskOnClickAnswer(choiceAnswer));
        }
    }

    public void TaskOnClick(Button choice)
    {
        if (choice.tag == "1")
        {
            buttonValue = 1;
        }
        else if (choice.gameObject.tag == "2")
        {
            buttonValue = 2;
        }
        else if (choice.gameObject.tag == "3")
        {
            buttonValue = 3;
        }
        else if (choice.gameObject.tag == "4")
        {
            buttonValue = 4;
        }
        else if (choice.gameObject.tag == "5")
        {
            buttonValue = 5;
        }
        else if (choice.gameObject.tag == "6")
        {
            buttonValue = 6;
        }
        Debug.Log(buttonValue);
        ArrowCheck();

    }
    public void TaskOnClickAnswer(Button choiceAnswer)
    {
        if (choiceAnswer.tag == "1")
        {
            answerButtonValue = 1;
        }
        else if (choiceAnswer.gameObject.tag == "2")
        {
            answerButtonValue = 2;
        }
        else if (choiceAnswer.gameObject.tag == "3")
        {
            answerButtonValue = 3;
        }
        else if (choiceAnswer.gameObject.tag == "4")
        {
            answerButtonValue = 4;
        }
        else if (choiceAnswer.gameObject.tag == "5")
        {
            answerButtonValue = 5;
        }
        else if (choiceAnswer.gameObject.tag == "6")
        {
            answerButtonValue = 6;
        }
        Debug.Log(answerButtonValue);
        ArrowCheck();
    }

    public void ArrowCheck()
    {
        if(buttonValue == answerButtonValue)
        {
            counter++;
            arrowList[buttonValue - 1].SetActive(true);
        }
        if (counter == 6)
        {
            finishPanel.SetActive(true);
            
        }
    }
    public void ResetBilmece()
    {
        for (int i = 0; i < arrowList.Length; i++)
        {
            arrowList[i].SetActive(false);
        }
    }
}
