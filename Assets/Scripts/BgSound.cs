using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgSound : MonoBehaviour
{
    private static BgSound bgSound;
   
    public SoundCont sc;

    private void Awake()
    {
    
     
        if(bgSound==null)
        {
            bgSound = this;
            DontDestroyOnLoad(bgSound);
        }
        else
        {
            Destroy(gameObject);
        }
    }


}
