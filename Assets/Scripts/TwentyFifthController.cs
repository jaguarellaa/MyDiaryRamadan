using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TwentyFifthController : MonoBehaviour
{
    public TextMeshProUGUI[] prayPieces, prayPiecesBoxes;
    public GameObject[] prayBoxes;
    public GameObject prayFinishPanel;
    public GameObject prayPanel;
    int counterPray;
    bool[] prayBools = new bool[7];

    public AudioSource[] sounds;
    public void DragPrayPiece(int pieceIndex)
    {
        prayPieces[pieceIndex].transform.position = Input.mousePosition;
    }
    public void DropPrayPiece(int prayIndex)
    {
        sounds[0].Play();
        float distance = Vector3.Distance(prayPieces[prayIndex].transform.position, prayBoxes[prayIndex].transform.position);
        if (distance < 57)
        {
            prayPieces[prayIndex].transform.position = prayBoxes[prayIndex].transform.position;
            prayPieces[prayIndex].color = Color.white;
            prayBools[prayIndex] = true;
            counterPray++;
            if (counterPray == 7)
            {
                sounds[2].Play();
                prayFinishPanel.SetActive(true);
            }
               

            sounds[1].Play();
            sounds[0].Stop();
        }
        else
        {
            prayPieces[prayIndex].transform.position = prayPiecesBoxes[prayIndex].transform.position;
        }
    }
    public void ResetPray()
    {
        counterPray = 0;
        prayPanel.SetActive(true);
        for (int i = 0; i < prayPieces.Length; i++)
        {
            prayPieces[i].transform.position = prayPiecesBoxes[i].transform.position;
            prayPieces[i].color = Color.black;
        }
    }
}
