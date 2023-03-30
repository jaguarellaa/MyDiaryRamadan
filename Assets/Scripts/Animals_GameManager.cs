using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animals_GameManager : MonoBehaviour
{
    public GameObject[] animPieces;
    public GameObject[] animBoxes;
    public GameObject[] animBoxesShow;
    public GameObject[] animBackBox;
    public GameObject animFinishPanel;
    public GameObject bowlAnim;
    Vector3[] initialAnimPiecePositions;
    public int counterAnim;
    bool counterBool;
    bool[] animBools = new bool[4];

    public AudioSource[] sounds;

    private void Start()
    {
        counterBool = true;
    }
    public void DragAnimPiece(int pieceIndex)
    {
       
        animPieces[pieceIndex].transform.position = Input.mousePosition;
    }
    public void DropAnimPiece(int animIndex)
    {

        sounds[0].Play();
        float distance = Vector3.Distance(animPieces[animIndex].gameObject.transform.position, bowlAnim.transform.position);

        if (distance < 150)
        {
            if (animIndex == 0)
            {
                sounds[2].Play();
            }
            else if (animIndex == 1)
            {
                sounds[3].Play();
            }
            else if (animIndex == 2)
            {
                sounds[4].Play();
            }
            else if (animIndex == 3)
            {
                sounds[5].Play();
            }
            else if (animIndex == 4)
            {
                sounds[6].Play();
            }
            else if (animIndex == 5)
            {
                sounds[7].Play();
            }
            else if (animIndex == 6)
            {
                sounds[8].Play();
            }
            else if (animIndex == 7)
            {
                sounds[9].Play();
            }
            else if (animIndex == 8)
            {
                sounds[10].Play();
            }
            
            animPieces[animIndex].transform.position = animBoxes[animIndex].transform.position;
            if (animIndex < 4)
            {
                animBools[animIndex] = true;
                animPieces[animIndex].SetActive(false);
                animBoxesShow[animIndex].SetActive(true);
            }
            else
            {
                animPieces[animIndex].transform.position = animBackBox[animIndex].transform.position;
            }

            counterAnim++;
            if (animIndex > 3)
            {
                counterAnim--;

                sounds[1].Play();
                sounds[0].Stop();
            }

        }
        else
        {
            animPieces[animIndex].transform.position = animBackBox[animIndex].transform.position;
        }

        Debug.Log(counterAnim);
        if (counterAnim == 4)
        {
            WinTime();

        }

    }

    public void WinTime()
    {
        new WaitForSeconds(0.5f);
        animFinishPanel.SetActive(true);
        sounds[11].Play();
    }
    public void ResetAnimals()
    {
        counterAnim = 0;
        for (int i = 0; i < animBackBox.Length; i++)
        {
            animPieces[i].transform.position = animBackBox[i].transform.position;
        }
        for (int i = 0; i < animPieces.Length; i++)
        {
            animPieces[i].SetActive(true);
        }
        for (int i = 0; i < animBoxesShow.Length; i++)
        {
            animBoxesShow[i].SetActive(false);
        }
    }
}
