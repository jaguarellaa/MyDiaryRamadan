using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftCard_FinishPanel : MonoBehaviour
{
    public GameObject giftCard_FinishPanel;
    public AudioSource sound;
    public void FinishPanel()
    {
        sound.Play();
        giftCard_FinishPanel.SetActive(true);
    }
}
