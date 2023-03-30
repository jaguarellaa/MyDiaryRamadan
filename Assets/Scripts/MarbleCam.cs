using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleCam : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
    }
}
