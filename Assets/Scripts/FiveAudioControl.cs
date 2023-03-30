using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FiveAudioControl : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] _text;
    public AudioSource voice;
    public string[] stringArray;
    [SerializeField] float timeBtwChars;
    [SerializeField] float timeBtwWords;
    int i;
    public GameObject sure_Panel;
    public AudioSource joy;
    void Start()
    {
        sure_Panel.SetActive(true);
    }

    public void TriggerEndCheck()
    {
        RestartTMP();
        i = 0;
        EndCheck();   
    }
    public void EndCheck()
    {
        if (i <= stringArray.Length - 1)
        {
            _text[i].text = stringArray[i] ;
            StartCoroutine(TextVisible(_text[i]));
        }
        
    }
    private IEnumerator TextVisible(TextMeshProUGUI givenText)
    {
        givenText.ForceMeshUpdate();
        int totalVisibleChars = givenText.textInfo.characterCount;
        int counter = 0;
        while (true)
        {
            int visibleCount = counter % (totalVisibleChars + 1);
            givenText.maxVisibleCharacters = visibleCount ;
            if (visibleCount >= totalVisibleChars)
            {
                i += 1;
                Invoke("EndCheck", timeBtwWords);
                break;
            }
            counter += 1;
            yield return new WaitForSeconds(timeBtwChars);
        }
    }

    public void RestartTMP()
    {
        for (int i = 0; i < _text.Length; i++)
        {
            _text[i].text = "";
        }
    }
    public void FinishPanel()
    {   
        sure_Panel.SetActive(false);
    }

    public void AudioCheck()
    {
        voice.Play();
    }
    public void Reset()
    {
        for (int i = 0; i < _text.Length; i++)
        {
            _text[i].text = "";
        }
    }

}

