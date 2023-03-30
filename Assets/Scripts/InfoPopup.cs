using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPopup : MonoBehaviour
{
    public GameObject infoImg;
  
    
    public void infoImgBtnExit()
    {

      
            infoImg.SetActive(false);
        
    
       
    }


    public void openInfoImg()
    {
       
        infoImg.SetActive(true);
        
    }


}
