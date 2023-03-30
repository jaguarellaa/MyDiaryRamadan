using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RandomImageGift : MonoBehaviour
{
    [SerializeField] private List<Image> imageList;
    [SerializeField] private List<Image> objectList;
    [SerializeField] private Image[] spawnPoint;
    [SerializeField] private TMP_InputField[] InputGuessGift;
    [SerializeField] private TextMeshProUGUI[] InputGuessGiftText;
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject GiftObject;
    [SerializeField] private GameObject buttonObject;
    [SerializeField] private GameObject panelObject;

    [SerializeField] private List<int> retainedNumber;
    [SerializeField] private int number;
    [SerializeField] private int score;


    public AudioSource[] sounds;

    int count1;
    int count2;
    int count3;
    int count4;
    int Numberofusers;
    private void Start()
    {
        Reset();
        for (int i = 0; i < InputGuessGift.Length; i++)
        {
            InputGuessGift[i].contentType = (TMP_InputField.ContentType)InputField.ContentType.IntegerNumber;
        }
    }
    void Update()
    {
        for (int i = 0; i < InputGuessGift.Length; i++)
        {
            if (InputGuessGift[i].text.Length > 4)
            {
                InputGuessGift[i].text = InputGuessGift[i].text.Substring(0, 4);
            }
        }
        bool inputIsValid = true;
        for (int i = 0; i < 4; i++)
        {
            if (string.IsNullOrEmpty(InputGuessGift[i].text))
            {
                inputIsValid = false;
                break;
            }
            else if (!int.TryParse(InputGuessGift[i].text, out int number))
            {
                inputIsValid = false;
                break;
            }
        }
        if (inputIsValid)
        {
            buttonObject.SetActive(false);
        }
        else
        {
            buttonObject.SetActive(true);
        }
    }
    public void Predictions()
    {
        for (int i = 0; i < spawnPoint.Length; i++)
        {
            int randomIndex = Random.Range(0, imageList.Count);
            Image randomImage = imageList[randomIndex];
            spawnPoint[i].sprite = randomImage.sprite;
            objectList.Add(spawnPoint[i]);
        }
        foreach (Image image in objectList)
        {
            if (image.sprite.name == "Gift1")
            {
                count1++;
            }
        }
        retainedNumber.Add(count1);
        Debug.Log("Gift1=" + count1);
        foreach (Image image in objectList)
        {
            if (image.sprite.name == "Gift2")
            {
                count2++;
            }
        }
        retainedNumber.Add(count2);
        Debug.Log("Gift2=" + count2);
        foreach (Image image in objectList)
        {
            if (image.sprite.name == "Gift3")
            {
                count3++;
            }
        }
        retainedNumber.Add(count3);
        Debug.Log("Gift3=" + count3);
        foreach (Image image in objectList)
        {
            if (image.sprite.name == "Gift4")
            {
                count4++;
            }
        }
        retainedNumber.Add(count4);
        Debug.Log("Gift4=" + count4);
    }
    public void Prediction()
    {
        bool inputIsValid = true;
        for (int i = 0; i < 4; i++)
        {
            if (string.IsNullOrEmpty(InputGuessGift[i].text))
            {
                inputIsValid = false;
                break;
            }
            else if (!int.TryParse(InputGuessGift[i].text, out int number))
            {
                inputIsValid = false;
                break;
            }
        }
        if (inputIsValid)
        {
            for (int i = 0; i < 4; i++)
            {
                int number = int.Parse(InputGuessGift[i].text);
                if (number == retainedNumber[i])
                {
                    
                    InputGuessGiftText[i].GetComponent<TextMeshProUGUI>().color = new Color(38f / 255f, 207f / 255f, 37f / 255f, 255f);
                    Debug.Log("True");
                    score += 20;

                }
                else
                {

                    sounds[0].Play();
                    //InputGuessGiftText[i].GetComponent<TextMeshProUGUI>().color = Color.red;
                    InputGuessGift[i].text = "";
                    Debug.Log("False");
                }
            }
            buttonObject.gameObject.SetActive(false);
            //StartCoroutine(WaitForSecondsAndDeactivateButton());
        }
        else
        {
            Debug.Log("Please fill all Input fields with numbers");
        }
        bool allGreen = true;
        for (int i = 0; i < 4; i++)
        {
            if (InputGuessGiftText[i].GetComponent<TextMeshProUGUI>().color != new Color(38f / 255f, 207f / 255f, 37f / 255f, 255f))
            {
                allGreen = false;
                break;
            }
        }
        if (allGreen)
        {
            StartCoroutine(WaitForSecondsAndDeactivateButton());
        }
        else
        {
            
            panelObject.SetActive(false);
        }
    }
    IEnumerator WaitForSecondsAndDeactivateButton()
    {
        yield return new WaitForSeconds(0.5f);
        sounds[1].Play();
        panelObject.SetActive(true);
    }
    public void Reset()
    {
        score = 0;
        count1 = 0;
        count2 = 0;
        count3 = 0;
        count4 = 0;
        retainedNumber.Clear();
        objectList.Clear();
        for (int i = 0; i < InputGuessGiftText.Length; i++)
        {
            InputGuessGift[i].text = "";
            InputGuessGiftText[i].color = new Color(1f, 0.5f, 0f, 1f);
        }
        panelObject.SetActive(false);
        buttonObject.SetActive(true);
        Predictions();
    }
}