 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class HafizaOyunuControl : MonoBehaviour
{
    int secimSayisi;
    GameObject secilenButton;
    GameObject butonunKendisi;
    public Sprite defaultSprite;
    public GameObject[] butonlar;
    //public TextMeshProUGUI toplamScore;
    public TextMeshProUGUI totalScore;
    public AudioSource[] sesler;
    public int target;
    int momentary;
    bool creationStatus;
    int createNumber;
    int totalObject;
    int score;
    public GameObject grid;
    public GameObject havuz;



    public GameObject finishPopUP;
    void Start()
    {
        secimSayisi = 0;
        creationStatus = true;
        createNumber = 0;
        havuz.SetActive(true);
        totalObject = havuz.transform.childCount;
        StartCoroutine(Olustur());
    }
    private void Update()
    {
        totalScore.text = score.ToString();
    }
    IEnumerator Olustur()
    {

        yield return new WaitForSeconds(.1f);
        while (creationStatus)
        {
            int randomNumber = Random.Range(0, havuz.transform.childCount - 1);
            if (havuz.transform.GetChild(randomNumber).gameObject != null)
            {
                havuz.transform.GetChild(randomNumber).transform.SetParent(grid.transform);
                createNumber++;
                if (createNumber == totalObject)
                {
                    creationStatus = false;

                    havuz.SetActive(false);
                }
            }
        }
    }
    public void Win()
    {
        sesler[3].Play();
        finishPopUP.SetActive(true);
    }

    public void ButtonControl(int value)
    {
        Kontrol(value);
    }
    public void ObjeVer(GameObject objem)
    {
        butonunKendisi = objem;
        butonunKendisi.GetComponent<Image>().sprite = butonunKendisi.GetComponentInChildren<SpriteRenderer>().sprite;
        butonunKendisi.GetComponent<Image>().raycastTarget = false;
        sesler[0].Play(); //kart 
    }
    public void ButonlarinDurumu(bool durum)
    {
        foreach (var item in butonlar)
        {
            if (item != null)
            {
                item.GetComponent<Image>().raycastTarget = durum;
            }
        }
    }
    public void Kontrol(int gelenDeger)
    {
        if (secimSayisi == 0)
        {
            secimSayisi = gelenDeger;
            secilenButton = butonunKendisi;
        }
        else
        {
            StartCoroutine(kontrolEt(gelenDeger));
        }
    }
    IEnumerator kontrolEt(int gelenDeger)
    {
        ButonlarinDurumu(false);
        yield return new WaitForSeconds(1);
        if (secimSayisi == gelenDeger)
        {
            momentary++;
            secilenButton.GetComponent<Image>().enabled = false;
            secilenButton.GetComponent<Button>().enabled = false;

            butonunKendisi.GetComponent<Image>().enabled = false;
            butonunKendisi.GetComponent<Button>().enabled = false;
            score += 50;

            //toplamScore.text = score.ToString();

            sesler[2].Play(); //kazandýn
            secimSayisi = 0;
            secilenButton = null;

            ButonlarinDurumu(true);

            if (target == momentary)
            {
                Win();
            }
        }
        else
        {
            secilenButton.GetComponent<Image>().sprite = defaultSprite;
            butonunKendisi.GetComponent<Image>().sprite = defaultSprite;
            sesler[1].Play(); //yanlýþ
            Debug.Log("Ev");
            secimSayisi = 0;
            secilenButton = null;
            ButonlarinDurumu(true);
        }
    }
    public void Reset()
    {
        momentary = 0;
        score = 0;
        secimSayisi = 0;
        secilenButton = null;
        createNumber = 0;
        creationStatus = true;
        foreach (var item in butonlar)
        {
            if (item != null)
            {
                item.GetComponent<Image>().enabled = true;
                item.GetComponent<Button>().enabled = true;
                item.GetComponent<Image>().sprite = defaultSprite;
                item.transform.SetParent(havuz.transform);
            }
        }
        havuz.SetActive(true);
        finishPopUP.SetActive(false);
        StartCoroutine(Olustur());
    }
}
