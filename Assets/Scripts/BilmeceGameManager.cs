using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BilmeceGameManager : MonoBehaviour
{
    public TextMeshProUGUI[] abdPieces;
    public GameObject[] abdBoxes;
    public GameObject[] backPos;
    public GameObject abdFinishPanel;

    Vector3[] initialAbdPiecePositions;
    int counterAbd;
    bool[] abdBools = new bool[8];

    public AudioSource[] sounds;

    void Awake()
    {
        initialAbdPiecePositions = new Vector3[abdPieces.Length];
        for (int i = 0; i < abdPieces.Length; i++)
        {
            initialAbdPiecePositions[i] = abdPieces[i].transform.position;
        }
    }

    public void DragAbdPiece(int pieceIndex)
    {
        abdPieces[pieceIndex].transform.position = Input.mousePosition;
    }

    public void DropAbdPiece(int abdIndex)
    {
        
        float distance = Vector3.Distance(abdPieces[abdIndex].transform.position, abdBoxes[abdIndex].transform.position);
        if (distance < 65)
        {
            abdPieces[abdIndex].transform.position = abdBoxes[abdIndex].transform.position;
            abdBools[abdIndex] = true;
            abdPieces[abdIndex].color = Color.white;
            counterAbd++;
            if (counterAbd == 6)
            {
                abdFinishPanel.SetActive(true);
                sounds[2].Play();

            }


            sounds[0].Play();
        }
        else
        {
            abdPieces[abdIndex].transform.position = backPos[abdIndex].transform.position;
          
            sounds[1].Play();

        }
    }
    public void ResetAbd()
    {
        counterAbd = 0;
        for (int i = 0; i < abdPieces.Length; i++)
        {
            abdPieces[i].color = Color.black;
            abdPieces[i].transform.position = backPos[i].transform.position;
        }
    }
}