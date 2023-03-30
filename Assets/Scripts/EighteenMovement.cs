using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class EighteenMovement : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private EighteenController _eighteenController;
    bool isMovement;
    int counter;
    int rndPos;
    public MamaKabiSlider _mamaKabiSlider;
    public GameObject[] backPoses;

    public void Start()
    {

    }
    public void DragHandler(BaseEventData data)
    {
        PointerEventData pointerData = (PointerEventData)data;

        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            (RectTransform)canvas.transform, pointerData.position, canvas.worldCamera, out position);

        transform.position = canvas.transform.TransformPoint(position);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("yessir");
        if(gameObject.tag == "cat" && collision.gameObject.tag == "mama")
        {
            GetComponent<Rigidbody2D>().isKinematic = true;
            StartCoroutine(StopMovement());
            counter = PlayerPrefs.GetInt("counter");
            counter++;
            Debug.Log(counter);
            PlayerPrefs.SetInt("counter", counter);
            _mamaKabiSlider.ScoreControl(100);
            CheckScore();
        }
        else if(gameObject.tag == "other"  && collision.gameObject.tag == "mama")
        {
            Debug.Log("here");
            StartCoroutine(BackPos());

        }
    }
    IEnumerator StopMovement()
    {
        yield return new WaitForSeconds(0.4f);
        GetComponent<EventTrigger>().enabled = false;
    }
    public void CheckScore()
    {
        if(counter == 4)
        {
            StartCoroutine(FinishPanel());
        }
    }
    IEnumerator FinishPanel()
    {
        yield return new WaitForSeconds(0.4f);
        _mamaKabiSlider.FinishPanelSetActive();
    }

    IEnumerator BackPos()
    {
        yield return new WaitForSeconds(0.4f);
        Debug.Log("random");
        rndPos = Random.Range(0, backPoses.Length);
        gameObject.transform.position = backPoses[rndPos].transform.position;
    }
}

  
