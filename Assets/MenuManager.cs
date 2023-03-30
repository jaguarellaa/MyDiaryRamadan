using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public AudioSource click;
   public void ClickSound()
    {
        click.Play();

    }


    public void GameScreen()
    {
        SceneManager.LoadScene(2);
    }


    public void AppQuit()
    {
        Application.Quit();
    }
}
