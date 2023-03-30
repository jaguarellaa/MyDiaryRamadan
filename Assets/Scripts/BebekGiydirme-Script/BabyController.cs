using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class BabyController : MonoBehaviour
{
    [SerializeField] GameObject[] dress;
    [SerializeField] GameObject[] shoes;
    [SerializeField] GameObject[] buckle;
    [SerializeField] Button[] button;
    [SerializeField] GameObject panel;
     public AudioSource joy;
    //bool purpleDress, redDress,PinkDress,yellowShoes,redShoes,pinkShoes,purpleBuckle,redBuckle,pinkBuckle;
    

    public void Update()
    {
        
        //if (purpleDress==true&&yellowShoes==true&&purpleBuckle==true)
        //{
        //    panel.SetActive(true);
        //}
        //else if(redDress == true && redShoes == true && redBuckle == true)
        //{
        //    panel.SetActive(true);
        //}
        //else if (PinkDress == true && pinkShoes == true && pinkBuckle == true)
        //{
        //    panel.SetActive(true);
        //}
    }
    public void DressPurple()
    {

        //purpleDress = true;
        dress[0].SetActive(false);
        dress[3].SetActive(false);
        dress[4].SetActive(true);
        dress[2].SetActive(false);
        dress[6].SetActive(false);
        dress[5].SetActive(true);
        dress[1].SetActive(true);
    }
    public void DressRed()
    {
    
        //redDress = true;
        dress[0].SetActive(false);
        dress[1].SetActive(false);
        dress[2].SetActive(true);
        dress[3].SetActive(true);
        dress[4].SetActive(false);
        dress[5].SetActive(true);
        dress[6].SetActive(false);
    }
    public void DressPink()
    {
        //PinkDress = true;
        dress[0].SetActive(false);
        dress[1].SetActive(true);
        dress[2].SetActive(false);
        dress[3].SetActive(true);
        dress[4].SetActive(false);
        dress[5].SetActive(false);
        dress[6].SetActive(true);
    }

    public void ShoesYellow()
    {
        //yellowShoes = true;
        shoes[0].SetActive(false);
        shoes[1].SetActive(true);
        shoes[2].SetActive(true);
        shoes[3].SetActive(false);
        shoes[4].SetActive(true);
        shoes[5].SetActive(false);
    }
    public void ShoesRed()
    {
        //redShoes = true;
        shoes[0].SetActive(true);
        shoes[1].SetActive(false);
        shoes[2].SetActive(false);
        shoes[3].SetActive(true);
        shoes[4].SetActive(true);
        shoes[5].SetActive(false);
    }
    public void ShoesPink()
    {
        //pinkShoes = true;
        shoes[0].SetActive(true);
        shoes[1].SetActive(false);
        shoes[2].SetActive(true);
        shoes[3].SetActive(false);
        shoes[4].SetActive(false);
        shoes[5].SetActive(true);
    }
    public void BucklePurple()
    {
        //purpleBuckle = true;
        buckle[0].SetActive(false);
        buckle[1].SetActive(true);
        buckle[2].SetActive(true);
        buckle[3].SetActive(false);
        buckle[4].SetActive(true);
        buckle[5].SetActive(false);
    }
    public void BuckleRed()
    {
        //redBuckle = true;
        buckle[0].SetActive(true);
        buckle[1].SetActive(false);
        buckle[2].SetActive(false);
        buckle[3].SetActive(true);
        buckle[4].SetActive(true);
        buckle[5].SetActive(false);
    }
    public void BucklePink()
    {
        //pinkBuckle = true;
        buckle[0].SetActive(true);
        buckle[1].SetActive(false);
        buckle[2].SetActive(true);
        buckle[3].SetActive(false);
        buckle[4].SetActive(false);
        buckle[5].SetActive(true);
    }
    public void Win()
    {
        joy.Play();
        panel.SetActive(true);
    }
    public void ResetBaby()
    {
        //purpleDress = false;
        //redDress = false;
        //PinkDress = false;
        //yellowShoes = false;
        //redShoes = false;
        //pinkShoes = false;
        //purpleBuckle = false;
        //redBuckle = false;
        //pinkBuckle = false;
        panel.SetActive(false);
        foreach (var dressObj in dress)
        {
            dressObj.SetActive(true);
        }
        foreach (var shoesObj in shoes)
        {
            shoesObj.SetActive(true);
        }
        foreach (var buckleObj in buckle)
        {
            buckleObj.SetActive(true);
        }
        dress[2].SetActive(false); dress[4].SetActive(false); dress[6].SetActive(false);
        shoes[1].SetActive(false); shoes[3].SetActive(false); shoes[5].SetActive(false);
        buckle[1].SetActive(false); buckle[3].SetActive(false); buckle[5].SetActive(false);
    }

}
