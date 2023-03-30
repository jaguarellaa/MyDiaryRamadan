using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abd_GameManager : MonoBehaviour
{
    public GameObject[] abdPieces;
    public GameObject[] abdBoxes;
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
        sounds[0].Play();
        float distance = Vector3.Distance(abdPieces[abdIndex].transform.position, abdBoxes[abdIndex].transform.position);
        if (distance < 50)
        {
            abdPieces[abdIndex].transform.position = abdBoxes[abdIndex].transform.position;
            abdBools[abdIndex] = true;
            counterAbd++;
            if (counterAbd == 8)
            {
                sounds[2].Play();
                abdFinishPanel.SetActive(true);
            }
               
            sounds[1].Play();
            sounds[0].Stop();
        }
        else
        {
            abdPieces[abdIndex].transform.position = initialAbdPiecePositions[abdIndex];
        }
    }
    public void ResetAbd()
    {
        counterAbd = 0;
        for (int i = 0; i < abdPieces.Length; i++)
        {
            abdPieces[i].transform.position = initialAbdPiecePositions[i];
        }
    }
}
