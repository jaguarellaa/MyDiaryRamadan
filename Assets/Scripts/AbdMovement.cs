using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AbdMovement : MonoBehaviour
{
    Vector2 pos;
    [SerializeField] private Canvas canvas;
    [SerializeField] private AbdController _abdController;
    bool drag;

    private void Start()
    {
        pos = gameObject.transform.position;
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
        if (gameObject.tag == collision.gameObject.tag)
        {
            _abdController.SetActiveImage(int.Parse(gameObject.tag) - 1);
            gameObject.SetActive(false);
        }
        else
        {
            drag = true;
        }
    }

    public void Back()
    {
        if (drag)
        {
            gameObject.transform.position = pos;
        }
    }
   
}



