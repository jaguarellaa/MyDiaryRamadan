using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonIndeks : MonoBehaviour
{
   
    public int buttonIndeks;
 

    public void stateActiveIndeks()
    {
        GameManger.gameManger.activeGameIndeks = buttonIndeks;
    }

 


}
