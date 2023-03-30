using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveFinishPanel : MonoBehaviour
{
    [SerializeField] GameObject finishPanel;
    public AudioSource joy;
    public void OpenFinishPanel()
    {

        joy.Play();
        finishPanel.SetActive(true);
    }
}
