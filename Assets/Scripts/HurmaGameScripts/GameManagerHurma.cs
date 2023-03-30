using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerHurma : MonoBehaviour
{
    public Canvas canvas;
    public Camera cam;
    [SerializeField] public GameObject Hand;
    [SerializeField] public GameObject Panel;
    [SerializeField] public GameObject basket;
    public AudioSource joy;
    bool check;
    public static int globalCount = 0;
    public DragDropHurma[] gm;
    public List<GameObject> hurmaPositions;
    public List<GameObject> gameHurma;
    [SerializeField] public Image timerBar;
    float timeleft;
    private float maxTime = 20f;




    private void Start()
    {
        timerBar.GetComponent<Image>();
        timeleft = maxTime;
        check = true;
    }
    private void Update()
    {
        if (timeleft > 0 && !Panel.activeInHierarchy)
        {
            timeleft -= Time.deltaTime;
            timerBar.fillAmount = timeleft / maxTime;
        }
        else
        {
            if (check)
            {
                joy.Play();
                check = false;
            }
            Panel.SetActive(true);
        }
    }
    public void IncreaseCount()
    {
        globalCount++;

    }
    public void Reset()
    {
        ResetHurmaPositions();
        for (int i = 0; i < gm.Length; i++)
        {
            gm[i].Start();
        }
    }
    public void ResetHurmaPositions()
    {
        Start();
        check = true;
        hurmaPositions.Clear();
        foreach (GameObject hurma in gameHurma)
        {

            hurmaPositions.Add(hurma);
        }
    }
}