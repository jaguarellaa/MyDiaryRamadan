using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllBackPos : MonoBehaviour
{
    [SerializeField] GameObject[] Images;
    [SerializeField] GameObject[] ClosingObjects;
    [SerializeField] GameObject FinishPanel;
    List<Vector3> poses;
    void Start()
    {
        poses = new List<Vector3>();
        for (int i = 0; i < Images.Length; i++)
        {
            poses.Add(Images[i].transform.position);
        }
    }

    public void RePos()
    {
        Debug.Log(123);
        for (int i = 0; i < Images.Length; i++)
        {
            ClosingObjects[i].gameObject.SetActive(false);
            Images[i].gameObject.SetActive(true);
            Images[i].transform.position = poses[i];
        }
        FinishPanel.SetActive(false);
    }

    
}
