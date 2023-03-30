using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CountdownTimerBalloon : MonoBehaviour
{
    [SerializeField] private Image timerBar;
    [SerializeField] private float maxTime = 30f;
    [SerializeField] private GameObject Panel;
    public WeaponBullet wb;
    public SpawnerBallon[] sb;
    //[SerializeField] private TextMeshProUGUI result;
    float timeleft;
    public AudioSource joy;
    private bool isPanelActive = false;

    public void Start()
    {
        timerBar.GetComponent<Image>();
        timeleft = maxTime;

        if (CollisionControlBalloon.scoretext == null)
        {
            Debug.Log("null1");
        }
        else
        {
            CollisionControlBalloon.score = 0;
            CollisionControlBalloon.scoretext.text = CollisionControlBalloon.score.ToString();
        }
    }
    void Update()
    {
        //result.text = CollisionControlBalloon.score.ToString();
        if (timeleft > 0)
        {
            timeleft -= Time.deltaTime;
            timerBar.fillAmount = timeleft / maxTime;
        }
        else
        {
            if (!isPanelActive)
            {
                isPanelActive = true;
                joy.Play();
                Panel.SetActive(true);
            }
            for (int i = 0; i < sb.Length; i++)
            {
                sb[i].CancelSpawn();
                WeaponBullet.updateEnabled = true;
            }
        }
    }
    public void Play_Again()
    {
        Start();
        isPanelActive = false;
        Panel.SetActive(false);
        for (int i = 0; i < sb.Length; i++)
        {
            sb[i].CancelSpawn();
            sb[i].spawn();
        }
        wb.Start();
        WeaponBullet.updateEnabled = false;
    }
}