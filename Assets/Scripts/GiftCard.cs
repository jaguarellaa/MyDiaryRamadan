using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftCard : MonoBehaviour
{
    public GameObject[] giftCardPieces;
    public GameObject giftCardCon, giftCardBoxes;
    Vector3[] initial_giftCardPieces; 
    Vector3 initial_GiftCardCon;
    void Awake()
    {
        initial_GiftCardCon = giftCardCon.transform.position;
        initial_giftCardPieces = new Vector3[giftCardPieces.Length];
        for (int i = 0; i < giftCardPieces.Length; i++)
        {
            initial_giftCardPieces[i] = giftCardPieces[i].transform.position;
        }
    }
    public void Drag_GifCardPiece(int pieceIndex)
    {
        giftCardPieces[pieceIndex].transform.position = Input.mousePosition;
    }

    public void Drop_GifCardPiece(int giftIndex)
    {
        float distance = Vector3.Distance(giftCardPieces[giftIndex].transform.position, giftCardPieces[giftIndex].transform.position);
        
        giftCardPieces[giftIndex].transform.position = giftCardPieces[giftIndex].transform.position;
    }
    public void Drag_GiftCardCon()
    {
        giftCardCon.transform.position = Input.mousePosition;
    }

    public void Drop_GiftCardCon()
    {
        float distance = Vector3.Distance(giftCardCon.transform.position, giftCardBoxes.transform.position);
        if (distance < 50)
        {
            giftCardCon.transform.position = giftCardBoxes.transform.position;
        }
        else
        {
            giftCardCon.transform.position = initial_GiftCardCon;
        }

    }
    public void ResetGiftCard()
    {
        giftCardCon.transform.position= initial_GiftCardCon;
        for (int i = 0; i < giftCardPieces.Length; i++)
        {
            giftCardPieces[i].transform.position = initial_giftCardPieces[i];
        }
    }

}
