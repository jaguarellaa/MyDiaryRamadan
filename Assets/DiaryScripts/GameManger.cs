using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{   

    
    public int activeGameIndeks;

    public static GameManger gameManger;

    void Awake()
    {

        if (gameManger == null)
            gameManger = this;
        //gameManger = this; //singleton
    }
}
