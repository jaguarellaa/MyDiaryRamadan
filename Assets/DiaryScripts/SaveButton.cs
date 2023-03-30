using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveButton : MonoBehaviour
{
    public List<Button> buttons;
    
    public Sprite active;

    

  


    public void CanvasStart()
    {
       
        if (PlayerDataModel.Data.butonIndex != null)
        {
            
            for (int i = 0; i < PlayerDataModel.Data.butonIndex.Count; i++)
            {
               
                buttons[PlayerDataModel.Data.butonIndex[i]].image.sprite = active;


            }

        }

    }


    public void SetButtonSprite()   
    {     

        

            for (int i = 0; i < PlayerDataModel.Data.butonIndex.Count; i++)
            {
                buttons[PlayerDataModel.Data.butonIndex[i]].image.sprite = active;
            }

        


    }

    public void SetButtonEnd()
    {
        buttons[29].image.sprite = active;
    }


}
