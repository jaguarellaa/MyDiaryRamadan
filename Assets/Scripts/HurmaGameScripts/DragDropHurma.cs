using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class DragDropHurma : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public GameManagerHurma gh;
    //[SerializeField] private TextMeshProUGUI countText;
    [SerializeField] public GameObject originalPosition;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    public AudioSource[] sound;

    public void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        //originalPosition.transform.position = rectTransform.position;   

        transform.position = originalPosition.transform.position;
        rectTransform.rotation = originalPosition.transform.rotation;
        GameManagerHurma.globalCount = 0;
        gh.Panel.SetActive(false);
        gh.Hand.SetActive(true);
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        Vector3 newPosition = rectTransform.anchoredPosition + eventData.delta / gh.canvas.scaleFactor;
        rectTransform.anchoredPosition = newPosition;
    }
    public void OnEndDrag(PointerEventData eventData)
    {   

        canvasGroup.blocksRaycasts = true;
        if (IsOverBasket(eventData))
        {   

            GameObject closestHurma = FindClosestHurma();
            if (closestHurma != null)
            {
                rectTransform.position = closestHurma.transform.position;
                rectTransform.rotation = Quaternion.Euler(0, 0, 50);
                GameManagerHurma.globalCount++;
                if (GameManagerHurma.globalCount == 7)
                {
                    gh.Panel.SetActive(true);
                    sound[2].Play();
                }
            }

            sound[0].Play();
        }
        else
        {
            rectTransform.position = originalPosition.transform.position;
            sound[1].Play();
        }
    }
    private GameObject FindClosestHurma()
    {
        GameObject closestHurma = null;
        float closestDistance = Mathf.Infinity;
        int closestIndex = -1;
        for (int i = 0; i < gh.hurmaPositions.Count; i++)
        {
            GameObject hurmaPosition = gh.hurmaPositions[i];
            float distance = Vector3.Distance(rectTransform.position, hurmaPosition.transform.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestHurma = hurmaPosition;
                closestIndex = i;
            }
        }
        if (closestIndex >= 0 && closestIndex < gh.hurmaPositions.Count)
        {
            gh.hurmaPositions.RemoveAt(closestIndex);
        }

        return closestHurma;
    }
    private bool IsOverBasket(PointerEventData eventData)
    {
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, results);
        foreach (RaycastResult result in results)
        {
            if (result.gameObject == gh.basket)
            {
                return true;
            }
        }
        return false;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        gh.Hand.SetActive(false);
    }
}