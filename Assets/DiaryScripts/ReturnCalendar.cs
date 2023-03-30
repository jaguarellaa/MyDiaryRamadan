using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ReturnCalendar : MonoBehaviour
{




  


    public void returnCalendar()
    {  


       
        PlayerDataModel.Data.AddIndex(GameManger.gameManger.activeGameIndeks);
        PlayerDataModel.Data.Save();

    }

    public void deleteData()
    {
        PlayerDataModel.Data.Delete();
    }


    public void returnCalendar30()
    {

        if(GameManger.gameManger.activeGameIndeks==29)
        {
            PlayerDataModel.Data.AddIndex(GameManger.gameManger.activeGameIndeks);
            PlayerDataModel.Data.Save();
        }

        

    }
}
