using System.Collections;
using UnityEngine;

public class Puzzle_GameManager : MonoBehaviour 
{
    public GameObject[] puzPieces;
    public GameObject[] puzBoxes;
    public GameObject[] initialPuzPie;
    public GameObject[] fixPuzPie;
    public GameObject puzFinishPanel;
    int counterPuz;
    bool[] puzBools = new bool[9];

    public AudioSource[] sounds;

    private void Awake()
    {
        for (int i = 0; i < puzPieces.Length; i++)
        {
            fixPuzPie[i].SetActive(false);
        }
    }
    public void DragPuzPiece(int pieceIndex)
    {
        puzPieces[pieceIndex].transform.position = Input.mousePosition;
    }

    public void DropPuzPiece(int puzIndex)
    {

        sounds[0].Play();
        float distance = Vector3.Distance(puzPieces[puzIndex].transform.position, puzBoxes[puzIndex].transform.position);
        if (distance < 50)
        {
            puzPieces[puzIndex].transform.position = puzBoxes[puzIndex].transform.position;
            puzBools[puzIndex] = true;
            fixPuzPie[puzIndex].SetActive(true);
            counterPuz++;
            sounds[1].Play();
            sounds[0].Stop();
            if (counterPuz == 9)
            {
                sounds[2].Play();
                puzFinishPanel.SetActive(true);
            }
              
        }
        else
        {
            puzPieces[puzIndex].transform.position = initialPuzPie[puzIndex].transform.position;
        }
    }
    public void ResetPuz()
    {
        counterPuz = 0;
        for (int i = 0; i < puzPieces.Length; i++)
        {
            puzPieces[i].transform.position = initialPuzPie[i].transform.position;
            fixPuzPie[i].SetActive(false);
        }
    }
}
