using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class FindLetters : MonoBehaviour
{
    [SerializeField] GameObject[] closeImage;
    [SerializeField] GameObject finishPanel;
    [SerializeField] Button[] button;
    int pointButton;
    //int totalObject;
    //bool creationStatus;
    //int createNumber;
    //[SerializeField] GameObject pool;
    [SerializeField] GameObject grid;
    public AudioSource correct;
    public AudioSource joy;
    public GameObject popup;

    private void Start()
    {
        //creationStatus = true;
        //createNumber = 0;
        //totalObject = pool.transform.childCount;
    }

    private void Update()
    {
        if (pointButton == 7)
        {


            StartCoroutine(WinTime());
        }
    }
    IEnumerator WinTime()
    {
        yield return new WaitForSeconds(1.5f);

       
        finishPanel.SetActive(true);
    }
    

    public void Button1True()
    {
        Debug.Log("basýldý");
        closeImage[0].SetActive(true);
        pointButton += 1;
       
        button[0].interactable = false;
        correct.Play();
        if (pointButton == 7)
        {

            StartCoroutine(Time());
            joy.Play();
        }
    }
    public void Button2True()
    {
        closeImage[1].SetActive(true);
        pointButton += 1;
        
        button[1].interactable = false;
        correct.Play();
        if (pointButton == 7)
        {

            StartCoroutine(Time());
            joy.Play();
        }
    }
    public void Button3True()
    {
        closeImage[2].SetActive(true);
        pointButton += 1;
     
        button[2].interactable = false;
        correct.Play();

        if (pointButton == 7)
        {

            StartCoroutine(Time());
            joy.Play();
        }
    }
    public void Button4True()
    {
        closeImage[3].SetActive(true);
        pointButton += 1;

        button[3].interactable = false;
        correct.Play();
        if (pointButton == 7)
        {

            StartCoroutine(Time());
            joy.Play();
        }
    }
    public void Button5True()
    {
        closeImage[4].SetActive(true);
        pointButton += 1;
        
        button[4].interactable = false;
        correct.Play();
        if (pointButton == 7)
        {

            StartCoroutine(Time());
            joy.Play();
        }
    }
    public void Button6True()
    {
        closeImage[5].SetActive(true);
        pointButton += 1;
       
        button[5].interactable = false;
        correct.Play();
        if (pointButton == 7)
        {

            StartCoroutine(Time());
            joy.Play();
        }
    }
    public void Button7True()
    {
        closeImage[6].SetActive(true);
        pointButton += 1;
        button[6].interactable = false;
        correct.Play();
        if (pointButton == 7)
        {
            StartCoroutine(Time());
            joy.Play();
        }
    }

    public void FindLettersReset()
    {
        pointButton = 0;
        //totalObject = pool.transform.childCount;
        //creationStatus = true;
        //createNumber = 0;
        popup.SetActive(false);
        finishPanel.SetActive(false);
        foreach (var closeImageActive in closeImage)
        {
            closeImageActive.SetActive(false);
        }
        foreach (var buttonActive in button)
        {
            buttonActive.interactable = true;
        }
    }

    IEnumerator Time()
    {
        yield return new WaitForSeconds(1.5f);


       
    }

}
