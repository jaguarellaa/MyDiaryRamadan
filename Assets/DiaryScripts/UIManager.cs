using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] GameObject CalendarPanel;
    [SerializeField] List<GameObject> panelList;


    public void HideAll()
    {
        foreach (var item in panelList)
        {
            item.SetActive(false);
        }

    }

    public void GoCalendar()
    {   

        HideAll();
        CalendarPanel.SetActive(true);
    }
}
