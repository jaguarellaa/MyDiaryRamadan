using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Linq;

public class GameManagerCrossword : MonoBehaviour
{
    [SerializeField] private string[] dictionary;
    [SerializeField] private TextMeshProUGUI puan_txt;
    [SerializeField] private List<GameObject> sign_button;
    [SerializeField] private GameObject finish_panel;
    //[SerializeField] private TextMeshProUGUI finish_Text;
    [SerializeField] public TextMeshProUGUI result_Text;
    [SerializeField] public ButtonControllerCrossword[] bt;
    //float timeleft;
    //private float maxTime = 35f;
    //[SerializeField] private GameObject[] randomObject;
    public bool clicked = false;
    string word = null;
    public static int puan;
    int found_word_numbers = 0;
    public static List<int> usedIndexes = new List<int>();
    private List<string> foundWords = new List<string>();
    public int count;
    public AudioSource[] sounds;

    public GameObject popup;
    private void Start()
    {
        //timerBar.GetComponent<Image>();
        //timeleft = maxTime;
        //int randomIndex = Random.Range(0, randomObject.Length);
        //while (usedIndexes.Contains(randomIndex))
        //{
        //    randomIndex = Random.Range(0, randomObject.Length);
        //}
        //usedIndexes.Add(randomIndex);
        //for (int i = 0; i < randomObject.Length; i++)
        //{
        //    if (i == randomIndex)
        //    {
        //        randomObject[i].SetActive(true);
        //    }
        //    else
        //    {
        //        randomObject[i].SetActive(false);
        //    }
        //}
        //if (usedIndexes.Count == randomObject.Length)
        //{
        //    usedIndexes.Clear();
        //}
        sign_button = new List<GameObject>();
    }
    public void sign_button_Create(GameObject ButtonController)
    {
        sign_button.Add(ButtonController);
        word = null;
        for (int i = 0; i < sign_button.Count; i++)
        {
            GameObject buttons = sign_button[i];
            word = word + buttons.name;
        }
    }
    private void Update()
    {
        result_Text.text = GameManagerCrossword.puan.ToString();
        //if (timeleft > 0 && !finish_panel.activeInHierarchy)
        //{
        //    timeleft -= Time.deltaTime;
        //    timerBar.fillAmount = timeleft / maxTime;
        //}
        //else
        //{
        //    //Time.timeScale = 0;
        //    finish_panel.SetActive(true);
        //}
        if (Input.GetMouseButtonDown(0))
        {
            clicked = true;           
        }       
        if (Input.GetMouseButtonUp(0))
        {
            clicked = false;
            create_post();
            puan_txt.text = puan.ToString();
           
        }
    }
    public void Index()
    {
        count++;
    }
    void create_post()
    {
        for (int i = 0; i < dictionary.Length; i++)
        {
            string words = dictionary[i];
            if (words != word)
            {
                
            }
        }
        for (int i = 0; i < dictionary.Length; i++)
        {
            string words = dictionary[i];
            if (words == word && !foundWords.Contains(word))
            {
                sounds[0].Play();
              
                puan += 10;
                found_word_numbers++;
                foundWords.Add(word);
                Index();
                for (int j = 0; j < sign_button.Count; j++)
                {
                    GameObject ButtonController = sign_button[j];
                    ButtonController.GetComponent<ButtonControllerCrossword>().dictionary_true = true;
                }
            }
        }
        sign_button.Clear();
        word = null;
        if (found_word_numbers == dictionary.Length/* || timeleft == 0*/)
        {
            StartCoroutine(ShowFinishPanelAfterDelay(0.4f));
        }
        IEnumerator ShowFinishPanelAfterDelay(float delayTime)
        {
            yield return new WaitForSeconds(delayTime);
            sounds[1].Play();
            finish_panel.SetActive(true);
        
            //finish_Text.text = puan.ToString();
        }
    }
    public void ResetButton()
    {
        popup.SetActive(false);
        count = 0;
        clicked = false;
        sign_button.Clear();
        word = null;
        found_word_numbers = 0;
        foundWords.Clear();
        puan = 0;
        result_Text.text = puan.ToString();
        finish_panel.SetActive(false);
        //timeleft = maxTime;
        for (int i = 0; i < bt.Length; i++)
        {
            bt[i].Start();
        }
    }
}