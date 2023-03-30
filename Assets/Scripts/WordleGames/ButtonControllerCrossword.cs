using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonControllerCrossword : MonoBehaviour
{
    public GameManagerCrossword gameManager;
    Image image;
    string letter;
    public bool letter_true = false;
    public bool dictionary_true = false;
    public int counter;
    public void Start()
    {
        image = GetComponent<Image>();
        letter = gameObject.name;
        gameManager.clicked = false;
        letter_true = false;
        image.color = Color.white;
        dictionary_true = false;
        counter = 0;
        GetComponent<ButtonControllerCrossword>().enabled = true;
        GetComponent<EventTrigger>().enabled = true;
    }
    private void Update()
    {
        EventTrigger trigger = gameObject.GetComponent<EventTrigger>();
        if (gameManager.clicked == false)
        {
            letter_true = false;
            image.color = Color.white;
        }
        if (dictionary_true == true)
        {                    
            counter = gameManager.count;
            switch (counter)
            {                  
                case 1:
                    GetComponent<Image>().color = Color.yellow;
                    GetComponent<ButtonControllerCrossword>().enabled = false;
                    GetComponent<EventTrigger>().enabled = false;
                    break;
                case 2:
                    GetComponent<Image>().color = new Color(39f / 255f, 113f / 255f, 231f / 255f, 255f);
                    GetComponent<ButtonControllerCrossword>().enabled = false;
                    GetComponent<EventTrigger>().enabled = false;
                    break;
                case 3:
                    GetComponent<Image>().color = Color.red;
                    GetComponent<ButtonControllerCrossword>().enabled = false;
                    GetComponent<EventTrigger>().enabled = false;
                    break;
                case 4:
                    GetComponent<Image>().color = new Color(1f, 0.5f, 0f, 1f);
                    GetComponent<ButtonControllerCrossword>().enabled = false;
                    GetComponent<EventTrigger>().enabled = false;
                    break;
                case 5:
                    GetComponent<Image>().color = Color.green;
                    GetComponent<ButtonControllerCrossword>().enabled = false;
                    GetComponent<EventTrigger>().enabled = false;
                    break;
                case 6:
                    GetComponent<Image>().color = Color.magenta;
                    GetComponent<ButtonControllerCrossword>().enabled = false;
                    GetComponent<EventTrigger>().enabled = false;
                    break;
                case 7:
                    GetComponent<Image>().color = Color.cyan;
                    GetComponent<ButtonControllerCrossword>().enabled = false;
                    GetComponent<EventTrigger>().enabled = false;
                    break;
                case 8:
                    GetComponent<Image>().color = new Color(149f / 255f, 68f / 255f, 193f / 255f, 255f);
                    GetComponent<ButtonControllerCrossword>().enabled = false;
                    GetComponent<EventTrigger>().enabled = false;
                    break;

                default:
                    break;
            }
        }
        if(dictionary_true == false)
        {
            counter=gameManager.count;
        }
    }
    public void green()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameManager.clicked = true;
        }
        if (gameManager.clicked == true)
        {
            image.color = Color.grey;

            if (letter_true == false)
            {
                gameManager.sign_button_Create(gameObject);
                letter_true = true;
            }
        }
    }
}