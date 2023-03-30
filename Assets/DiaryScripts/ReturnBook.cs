using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnBook : MonoBehaviour
{
    public Puzzle_GameManager puzzle1;
    public Maze_GameManager maze2, maze16, maze21;
    public HafizaOyunuControl hafiza3;
    public CountdownTimerBalloon balloon4;
    public FiveController ihlas5;
    public RandomImageGift gift6;
    public Puzzle_GameManager puzzle7;
    public Abd_GameManager abd9;
    public FiveController fatiha10;
    public BilmeceGameManager match13;
    public GameManagerCrossword cross14;
    public FifteenController fatiha15;
    public CountdownTimerBalloon2 balloon17;
    public Animals_GameManager mama18;
    public Coloring color19;
    public TwentyController kevser20;
    public GameManagerHurma hurma22;
    public GameManagerCrossword cross23;
    public MarbleSenderRotation marble24;
    public TwentyFifthController nas25;
    public Coloring color26;
    public Coloring_Mosque mos28;
    public BabyController baby29;
    public FireworksControl fire30;
    public RamadanLetters alphabet;
    public FindLetters findLetters;
    public MarbleTimer timer24;



    public void replayGame()
    {
        if (GameManger.gameManger.activeGameIndeks == 0)
        {
            puzzle1.ResetPuz();
        }
        else if (GameManger.gameManger.activeGameIndeks == 1)
        {
            maze2.RestartMaze();
        }
        else if (GameManger.gameManger.activeGameIndeks == 2)
        {
            hafiza3.Reset();
        }
        else if (GameManger.gameManger.activeGameIndeks == 3)
        {
            balloon4.Play_Again();
        }
        else if (GameManger.gameManger.activeGameIndeks == 4)
        {
            ihlas5.ResetPray();
        }
        else if (GameManger.gameManger.activeGameIndeks == 5)
        {
            gift6.Reset();
        }
        else if (GameManger.gameManger.activeGameIndeks == 6)
        {
            puzzle7.ResetPuz();
        }
        else if (GameManger.gameManger.activeGameIndeks == 7)
        {
            alphabet.ResetGame();
        }
        else if (GameManger.gameManger.activeGameIndeks == 8)
        {
            abd9.ResetAbd();
        }
        else if (GameManger.gameManger.activeGameIndeks == 9)
        {
            fatiha10.ResetPray();
        }
        else if (GameManger.gameManger.activeGameIndeks == 10)
        {
        }
        else if (GameManger.gameManger.activeGameIndeks == 11)
        {
            findLetters.FindLettersReset();
        }
        else if (GameManger.gameManger.activeGameIndeks == 12)
        {
            match13.ResetAbd();
        }
        else if (GameManger.gameManger.activeGameIndeks == 13)
        {
            cross14.ResetButton();
        }
        else if (GameManger.gameManger.activeGameIndeks == 14)
        {
            fatiha15.ResetPray();
        }
        else if (GameManger.gameManger.activeGameIndeks == 15)
        {
            maze16.RestartMaze();
        }
        else if (GameManger.gameManger.activeGameIndeks == 16)
        {
            balloon17.Play_Again();
        }
        else if (GameManger.gameManger.activeGameIndeks == 17)
        {
            mama18.ResetAnimals();
        }
        else if (GameManger.gameManger.activeGameIndeks == 18)
        {
            color19.ResetColoringChildren();
        }
        else if (GameManger.gameManger.activeGameIndeks == 19)
        {
            kevser20.ResetPray();
        }
        else if (GameManger.gameManger.activeGameIndeks == 20)
        {
            maze21.RestartMaze();
        }
        else if (GameManger.gameManger.activeGameIndeks == 21)
        {
            hurma22.Reset();
        }
        else if (GameManger.gameManger.activeGameIndeks == 22)
        {
            cross23.ResetButton();
        }
        else if (GameManger.gameManger.activeGameIndeks == 23)
        {
            marble24.ResetMarble();
            timer24.Reset();
        }
        else if (GameManger.gameManger.activeGameIndeks == 24)
        {
            nas25.ResetPray();
        }
        else if (GameManger.gameManger.activeGameIndeks == 25)
        {
            color26.ResetColoring();
        }
        else if (GameManger.gameManger.activeGameIndeks == 26)
        {


        }
        else if (GameManger.gameManger.activeGameIndeks == 27)
        {
            mos28.ResetColoringMos();
        }
        else if (GameManger.gameManger.activeGameIndeks == 28)
        {
            baby29.ResetBaby();
        }
        else if (GameManger.gameManger.activeGameIndeks == 29)
        {
            fire30.FireworksReset();
        }
        
    }
}
