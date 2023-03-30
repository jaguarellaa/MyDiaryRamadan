using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class MarbleArrow : MonoBehaviour
{
    public Camera camMarble;

    public GameObject marbleArrow;
    private Vector3 mousePosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Input.mousePosition;
            mousePosition = camMarble.ScreenToWorldPoint(mousePosition);
            Marble();
        }
    }

    void Marble()
    {
        Vector2 direction = camMarble.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        marbleArrow.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}

