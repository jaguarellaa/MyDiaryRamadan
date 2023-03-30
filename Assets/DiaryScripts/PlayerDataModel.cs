using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerDataModel : DataModel
{
    public static PlayerDataModel Data;

    public List<int> butonIndex;
    

    public PlayerDataModel Load()
    {
        if (Data == null)
        {
          butonIndex= new List<int>();

            Data = this;
            object data = LoadData();
            if (data != null)
            {
                Data = (PlayerDataModel)data;
            }
        }
        return Data;
    }

    public void AddIndex(int index)
    {
       if(!butonIndex.Contains(index))
        {
            butonIndex.Add(index);

        }
    }

    public void Save()
    {
        Save(Data);
    }
}
