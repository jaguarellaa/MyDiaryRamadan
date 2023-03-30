using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EighteenController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] texts;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject[] positions;
    int counter;
    int randomValue;
    int tempValue = -1;
    public void SetActiveImage(int value)
    {
        texts[value].gameObject.SetActive(true);
        counter++;
        CheckPanelSituation(counter);
    }

    public void CheckPanelSituation(int value)
    {
        if (value == 8)
        {
            StartCoroutine(SetActiveFinishPanel());
        }
    }
    IEnumerator SetActiveFinishPanel()
    {
        yield return new WaitForSeconds(0.5f);
        panel.SetActive(true);
    }

    public Vector2 PositionBack()
    {
        Vector2 pos = new Vector2();
    point:
        randomValue = Random.Range(0, positions.Length);
        if (tempValue == randomValue)
        {
            goto point;
        }
        else
        {
            pos = positions[randomValue].transform.position;
        }
        return pos;
    }


}