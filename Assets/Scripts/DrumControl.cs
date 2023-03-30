using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumControl : MonoBehaviour
{
    [SerializeField] private AudioSource _drumVoice;

    public void DrumController()
    {
        _drumVoice.Play();
    }
}
